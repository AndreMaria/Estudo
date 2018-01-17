package rest

import akka.actor.{Actor, ActorLogging, Props}
import model.UserRepository
import model.User

object RequestUser {
  def prop(): Props = {
    Props(classOf[RequestUser])
  }
}
case class Parameters(param:String)
case object GetHealthRequest
case class SetStatusRequest(email:String)
case class UserResponse(user: Option[UserModel])
case class MensagemResponse(mensagem:String)
case class UserModel(id: Int ,name: String,email: String ,passworld : String)

class RequestUser extends Actor with ActorLogging {

  def receive :Receive = {
    case GetHealthRequest => log.debug("ocorrendo no ator do Health")
      sender() ! MensagemResponse("VAI TOMAR NO CU!!!!!!!!")
    case request: SetStatusRequest =>  log.debug("Get User " ,request.email)
      var email = request.email
      var entity = UserRepository.GetUser(request.email)
      var item = new UserModel(entity.get.id, entity.get.name, entity.get.email,entity.get.passworld)
      sender() ! UserResponse(Option(item))
  }
}
