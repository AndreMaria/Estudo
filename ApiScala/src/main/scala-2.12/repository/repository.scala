package repository

import java.sql._
import scala.collection.mutable.ArrayBuffer
/**
 * Created by AndreMaria on 03/01/2018.
 */
class repository {

  val url = ""
  val driver = ""
  val username = ""
  val password = ""
  var connection: Connection

  private def startCopnnection(): Connection = {
    Class.forName(driver)
    return  DriverManager.getConnection(url,username,password)
  }

  private def Command(query: String) : PreparedStatement = {
    connection = startCopnnection()
    connection.prepareStatement(query)
  }

  private def bindParameters(statement: PreparedStatement,params: TraversableOnce[Any]): Int = {
    var index = 1
    for (param <- params) {
      param match {
        case i: Int => statement.setInt(index, i)
        case s: String => statement.setString(index, s)
        case b: Boolean => statement.setBoolean(index, b)
        case _ =>
          throw new IllegalArgumentException("Unsupported data type " + param)
      }
      index += 1
    }
    index
  }

  def executeQuery(query: String,params: Option[Seq[Any]]): ResultSet = {
    var statement = Command(query)
    bindParameters(statement, params)
    statement.executeQuery()
  }

  def execute[T](f:ResultSet => T,rs: ResultSet): Seq[T] = {
    try{
      val results = new ArrayBuffer[T]()
      while (rs.next()){
        results += f(rs)
      }
      results
    }
    finally {
      rs.close()
      connection.close()
    }
  }

}
