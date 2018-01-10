package service

import akka.actor.AbstractActor.Receive
import akka.actor.{ActorLogging, Actor, Props}
import repository.usuarioRepository
import model.usuario

object RequestHandler {
  def prop(): Props = {
    Props(classOf[RequestHandler])
  }
}


case object getLoginRequest
case class usuarioResponse(user :Seq[usuario])
/**
 * Created by AndreMaria on 03/01/2018.
 */
class RequestHandler extends Actor  with ActorLogging{

  override def receive : Receive = {
    case getLogin => log.debug("Ocorrendo no ator do Login")
      val user = usuarioRepository.select("CALL ALL_USERS();",None)
      sender() ! usuarioResponse(user)
  }
}
