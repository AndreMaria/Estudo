
import akka.actor.ActorSystem
import akka.http.scaladsl.marshallers.sprayjson.SprayJsonSupport
import org.w3c.dom.css.CSSValue
import rest._
import model.User
import org.json4s.native.Json
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
import org.json4s._


import scala.io.StdIn

trait JsonSupport extends SprayJsonSupport with DefaultJsonProtocol {
  implicit val healthFormat = jsonFormat1(rest.Parameters)
  implicit val responseFormat = jsonFormat4(UserModel)
}

object ApiProject extends JsonSupport{

  val host = "localhost"
  val port = 8081

  def main(args: Array[String]): Unit = {
    implicit val system = ActorSystem("simple-rest-system")
    implicit val materializer = ActorMaterializer()
    implicit val executionContext = system.dispatcher

    val requestUser = system.actorOf(RequestUser.prop(),"requestUser")

    val route : Route = {
      implicit val timeout = Timeout(55.seconds)

      path("login") {
        get {
          onSuccess( requestUser ? GetHealthRequest){
            case response : MensagemResponse =>
              complete( StatusCodes.OK, s"Essa porra rodou (${response.mensagem})")
            case _ => complete(StatusCodes.InternalServerError , s"Deu erro nessa caraia")
          }
        }
        post{
          entity(as[rest.Parameters]) { statusReport =>
            onSuccess(requestUser ? SetStatusRequest(statusReport.param)){
              case response: UserResponse =>{
                complete(response.user)
              }
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
