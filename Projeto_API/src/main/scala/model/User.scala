package model

import javax.persistence._
import repository.RepositoryBase


@Entity
@Table(name = "Users")
class User{

  @Id
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  var id: Int = _
  var name: String = _
  var email: String = _
  var passworld : String = _
}

object UserRepository extends RepositoryBase[User]{
  def GetUser(email:String): Option[User] = {
    println(s"Método GetUser => email :${email}")
    val query = session.createSQLQuery("CALL GetUser(:email)").addEntity(classOf[model.User]).setParameter("email",email)
    println(s"Método GetUser => Query :${query}")
    var user = query.uniqueResult().asInstanceOf[User]
    Option(user)
  }
}
