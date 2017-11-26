package repository

import java.sql._

import scala.collection.mutable.ArrayBuffer



class repository {

  val url = "jdbc:mysql://localhost:3306/tutorial_scala"
  val driver = "com.mysql.jdbc.Driver"
  val username = "root"
  val password = "@ndre1980"
  var connection: Connection = _

  private def StartConnection() : Connection = {
    Class.forName(driver)
    return DriverManager.getConnection(url,username,password)
  }

  private def Command(query: String): PreparedStatement = {
     connection = StartConnection()
     connection.prepareStatement(query)
  }

  def ExecuteQuery(query: String,params: Option[Seq[Any]]) : ResultSet = {
    var statement = Command(query)
    bindParameters(statement, params)
    statement.executeQuery()
  }

  private def bindParameters(statement: PreparedStatement,
                             params: TraversableOnce[Any]): Int = {
    var index = 1
    for (param <- params) {
      param match {
        case i: Int => statement.setInt(index, i)
        case s: String => statement.setString(index, s)
        case b: Boolean => statement.setBoolean(index, b)
        case _ =>
          throw new IllegalArgumentException("Unsupported data type "
            + param.asInstanceOf[AnyRef].getClass.getName + ": " + param)
      }
      index += 1
    }
    index
  }

  def Execute[T](f:ResultSet => T,rs: ResultSet) : Seq[T] = {
    try {
      val results = new ArrayBuffer[T]
      while (rs.next()){
        results += f(rs)
      }
      results
    } finally {
      rs.close()
      //statement.close()
      connection.close()
    }
  }

}
