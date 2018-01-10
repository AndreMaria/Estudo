import akka.actor.ActorSystem
import akka.http.scaladsl.marshallers.sprayjson.SprayJsonSupport
import akka.stream.ActorMaterializer

/**
 * Created by AndreMaria on 03/01/2018.
 */
class Acesso extends SprayJsonSupport{

  val host = "Localhost"
  val port = "8081"

  def main (args: Array[String]){

    implicit val system = ActorSystem()
    implicit val materializer = ActorMaterializer()
    implicit val executionContext = system.dispatcher


  }

}
