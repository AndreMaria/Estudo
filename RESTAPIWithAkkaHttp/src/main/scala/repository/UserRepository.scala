package repository

import java.sql.ResultSet
import akka.actor.{Actor, ActorLogging, Props}
import scala.concurrent.Future

case class User(Id: Int, Name: String, Email: String, Login: String, Password: String ){
  require( Id > 0 , "Código invalido")
}

object UserRepository {
  def Select(query: String, params: Option[Seq[Any]]) : Seq[User] = {
    val rp = new repository();
    var rs = rp.ExecuteQuery(query,params)
    val result = rp.Execute[repository.User](
      F => {
        User(rs.getInt("id"),rs.getString("user_name"),rs.getString("user_email"),rs.getString("login"),"")
      }
      ,rs)
    if(null != rs){
      rs.close()
    }
    return result
  }
}
