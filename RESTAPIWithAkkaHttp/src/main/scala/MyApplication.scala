import Map.{Texto}
import akka.actor.ActorSystem
import akka.http.scaladsl.marshallers.sprayjson.SprayJsonSupport
import org.w3c.dom.css.CSSValue
import rest.{Health}
import spray.json.DefaultJsonProtocol //akka-actor
//Os módulos Akka HTTP implementam uma pilha HTTP completa do servidor e do cliente em cima do akka-actor e akka-stream.
import akka.http.scaladsl.Http
import akka.http.scaladsl.model.StatusCodes
import akka.http.scaladsl.server.Directives._
import akka.http.scaladsl.server.Route
import akka.stream.ActorMaterializer //akka-stream
import akka.util.Timeout
import akka.pattern.ask
import scala.concurrent.duration._
import spray.json._

import scala.io.StdIn
import rest._


// Essa interface corresponde ao método post
// A diretiva as[Health] tem um parametro implicito do tipo FromRequestUnmarshaller[T]
// Assim implementamos jsonFormat2(Health)
trait JsonSupport extends SprayJsonSupport with DefaultJsonProtocol {
  implicit val healthFormat = jsonFormat2(Health)
  //implicit val parameterFormat = jsonFormat1(Parameter)
  implicit val resultFormat = jsonFormat1(ListTexto)
}

object MyApplication extends JsonSupport{

  val host = "localhost"
  val port = 8081

  def main(args: Array[String]): Unit = {

    /*O sistema ActorSystem é necessário para definir o sistema de ator que será usado para executar
    as várias etapas de processamento de uma solicitação de forma automática. Akka HTTP converte o
    DSL que criamos em uma definição de fluxo.
    Esse fluxo pode ser visto como um plano das etapas que um pedido leva desde o início até o fim.*/
    implicit val system = ActorSystem("simple-rest-system")

    /*O ActorMaterializer implícito converterá esse fluxo em um conjunto de atores da Akka para que
    múltiplas solicitações possam ser executadas simultaneamente sem interferir entre si, que é
    executado no sistema de ator implicitamente definido */
    implicit val materializer = ActorMaterializer()

    /*Dispatchers implementam a interface ExecutionContext e, portanto, podem ser usados ​​para executar invocações futuras etc.*/
    implicit val executionContext = system.dispatcher

    //Inicia uma isntancia de um ActorRef
    // RequestHandler representa as propriedades desejadas para o actor
    val requestHandler = system.actorOf(RequestHandler.prop(),"requestHandler")

    //Define a rota
    //É um alias simples para uma função transformando um RequestContext em um Futuro [RouteResult].
    val route : Route = {
      implicit val timeout = Timeout(55.seconds)

      path("health") {
        get {
          //No trecho requestHandler ? GetHealthRequest
          //O ator requestHandler é instanciado e usado para lidar com todos os pedidos da rota
          //O método (ask) retornará um Future[Any] esse método requer um tempo limite que é usado
          // para limitar a quantidade de tempo que espera a resposta.
          //O objeto GetHealthRequest é a mensagem para o ator
          // Quando este Futuro foi concluído com sucesso, a correspondência de padrões é aplicada à resposta do Ator.
          // Cada caso na combinação de padrões define como a rota deve ser concluída
          onSuccess(requestHandler ? GetHealthRequest){
            case response: HealthResponse => complete(
              StatusCodes.OK, s"Everything is ${response.helath.status} and ${response.helath.description}")
            case _ => complete(StatusCodes.InternalServerError)
          }
        }
        post{
          entity(as[Health]) { statusReport =>
            onSuccess(requestHandler ? SetStatusRequest(statusReport)){
              case response: HealthResponse =>
                complete(StatusCodes.OK, s"Posted health as ${response.helath.status} !")
              case _ => complete(StatusCodes.InternalServerError)
            }
          }
        }
      }
      path("mapping"){
        get{
          parameters("texto".as[String]){(texto) =>
            onSuccess(requestHandler ? SetMappingRequest(texto)) {
              case response: MappingResponse => complete(
                StatusCodes.OK,response.texto.list.toString()
              )
              case _ => complete(StatusCodes.InternalServerError)
            }
          }
        }
      }
    }

    //Startup, and listen for requests
    //A Rota criada usando o Route DSL é então "vinculada" a uma porta para começar a atender solicitações HTTP:
    val bindingFuture = Http().bindAndHandle(route, host, port)
    println(s"Waiting for requests at http://$host:$port/...\nHit RETURN to terminate")
    StdIn.readLine()

    //Shutdown
    bindingFuture.flatMap(_.unbind())
    system.terminate()
  }
}
