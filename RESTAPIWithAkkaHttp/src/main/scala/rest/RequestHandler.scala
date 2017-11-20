package rest

import akka.actor.{Actor, ActorLogging, Props}

object RequestHandler {
  def prop(): Props = {
    Props(classOf[RequestHandler])
  }
}

case class Health(status: String, description: String)
case object GetHealthRequest
case class HealthResponse(helath: Health)

class RequestHandler extends Actor with ActorLogging {

  var status : Health = Health("Healthy","Iniciado")

  def receive :Receive = {
    case GetHealthRequest => log.debug("ocorrendo no ator do Health")
    sender() ! HealthResponse(status)
  }
}
