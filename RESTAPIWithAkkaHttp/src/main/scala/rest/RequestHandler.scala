package rest

import akka.actor.{Actor, ActorLogging, Props}

//Esse objeto o método prop que representa as propriedades do actor
object RequestHandler {
  def prop(): Props = {
    Props(classOf[RequestHandler])
  }
}

case class Health(status: String, description: String)
case object GetHealthRequest
case class SetStatusRequest(helath: Health)
case class HealthResponse(helath: Health)

class RequestHandler extends Actor with ActorLogging {

  var status : Health = Health("Healthy","Iniciado")

  def receive :Receive = {
    //Aqui utilizamos o método sender para responder
    //A resposta é baseada no objeto Health que possui um status e descrição
    case GetHealthRequest => log.debug("ocorrendo no ator do Health")
      sender() ! HealthResponse(status)
    case request: SetStatusRequest =>  log.debug("Update status to {}" ,request.helath)
      status = request.helath
      sender() ! HealthResponse(status)
  }
}
