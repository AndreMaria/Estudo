package rest

import akka.actor.{Actor, ActorLogging, Props}


object RequestHandlerUser {
  def prop(): Props ={
    Props(classOf[RequestHandlerUser])
  }
}

case class User(Id: Int, Name: String, Email: String, Login: String, Password: String )
case class Users(users:Seq[User])

case object GetUserRequest
case class SetUserRequest(user: User)
case class UserResponse(user: User)
case class UserResponseList(users: Seq[User])

class RequestHandlerUser extends Actor  with ActorLogging {
  override def receive: Receive = {
    case GetUserRequest => log.debug("ocorrendo no ator do User")
      val userList = repository.UserRepository.Select("CALL ALL_USERS();",None).map(User => repository.User)
      sender() ! UserResponseList(null)
    case GetUserRequest => log.debug("ocorrendo no ator do User")
      var user = repository.UserRepository.Select("CALL ALL_USERS();",None).map(User => repository.User).head
      sender() ! UserResponse(null)
  }
}