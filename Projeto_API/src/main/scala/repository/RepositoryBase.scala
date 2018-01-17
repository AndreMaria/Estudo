package repository

import model.User
import org.hibernate.Session

class RepositoryBase[T] {

  val session: Session = HibernateUtil.getSessionFactory.openSession()

  def Save(entity:T) = {
    session.beginTransaction()
    session.save(entity)
    session.getTransaction().commit()
  }

  def Delete(entity:T) = {
    session.beginTransaction()
    session.delete(entity)
    session.getTransaction().commit()
  }
}
