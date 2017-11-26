package rest

import akka.actor.{Actor, ActorLogging, Props}

//Esse objeto o método prop que representa as propriedades do actor
object RequestHandler {
  def prop(): Props = {
    Props(classOf[RequestHandler])
  }
}

case class Health(status: String, description: String){
  require(status == "Healthy" || status == "Degraded" || status == "Critical" || status == "Unknown",
    "status must be one of: [\"Healthy\",\"Degraded\",\"Critical\", or \"Unknown\"]")
}
case object GetHealthRequest
case class SetStatusRequest(helath: Health)
case class HealthResponse(helath: Health)

case class GetUserRequest(user: repository.User)
case class SetUserRequest(user: repository.User)
case class UserResponse(user: repository.User)
case class UserResponseList(users: Seq[repository.User])

class RequestHandler extends Actor with ActorLogging {

  var status : Health = Health("Healthy","Iniciado")
  var user : repository.User = repository.User(0,"","","","")

  def receive :Receive = {
    //Aqui utilizamos o método sender para responder
    //A resposta é baseada no objeto Health que possui um status e descrição
    case GetHealthRequest => log.debug("ocorrendo no ator do Health")
      sender() ! HealthResponse(status)
    case request: SetStatusRequest =>  log.debug("Update status to {}" ,request.helath)
      status = request.helath
      sender() ! HealthResponse(status)
    case request: GetUserRequest => log.debug("ocorrendo no ator do User")
      request.user = UserResponseList(repository.UserRepository.Select("CALL ALL_USERS();",None)).users.head
      sender() ! UserResponseList(repository.UserRepository.Select("CALL ALL_USERS();",None))
    case GetUserRequest => log.debug("ocorrendo no ator do User")
      sender() ! UserResponse(repository.UserRepository.Select("CALL ALL_USERS();",None).head)
  }
}
