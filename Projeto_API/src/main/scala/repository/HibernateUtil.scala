package repository

import org.hibernate.SessionFactory
import org.hibernate.cfg.AnnotationConfiguration

object HibernateUtil {

  private val sessionFactory = buildSessionFactory

  private def buildSessionFactory: SessionFactory = {
    try{
      return  new AnnotationConfiguration().configure().buildSessionFactory()
    }catch {
      case ex :Throwable => {
        System.err.println("Initial SessionFactory creation failed." + ex)
        throw new ExceptionInInitializerError(ex)
      }
    }
  }

  def getSessionFactory = sessionFactory

  def shutdown = {
    getSessionFactory.close()
  }

}
