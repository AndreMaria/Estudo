package com.ru.waka.app.repository

import java.sql.{Connection, DriverManager, ResultSet}
import java.util

class BaseSql {

  def CreateConnection() : Connection = {
    println("CreateConnection")
    // connect to the database named "mysql" on the localhost
    val driver = "net.sourceforge.jtds.jdbc.Driver"
    //val url = "jdbc:jtds:sqlserver://AA-PC\\SQLEXPRESS;DatabaseName=TUTORIAL_SCALA"
    //Data Source=AA-PC\SQLEXPRESS;Initial Catalog=TUTORIAL_SCALA;User ID=sa;Password=***********
    //val url = "jdbc:jtds:sqlserver://AA-PC\\SQLEXPRESS:1433/TUTORIAL_SCALA;instance=SQLEXPRESS;useUnicode=true;characterEncoding=UTF-8"
    val url = "jdbc:jtds:sqlserver://AA-PC\\SQLEXPRESS:1433;databaseName=AdventureWorks;user=sa;password=@ndre1980;"

    println(url)
    val username = "sa"
    val password = "@ndre1980"

    // there's probably a better way to do this
    var connection:Connection = null
    println("Start Drive")
    try{
      // make the connection
      Class.forName("net.sourceforge.jtds.jdbc.Driver")
      println("make the connection")
      connection = DriverManager.getConnection(url)
    } catch {
      case e => {
        println("Erro:" + e.getMessage())
        if(null != connection){
          connection.close();
        }
      }
    }

    return  connection
  }

  def CreateCommand(query:String) : ResultSet = {
    println("CreateCommand")
    var connection:Connection = this.CreateConnection()
    var resultSet : ResultSet = null;
    if(null != connection){
      try{
        // create the statement, and run the select query
        val statement = connection.createStatement()
        resultSet = statement.executeQuery(query)
      }
      catch {
        case e => e.printStackTrace
      }
      if(null != connection){
        connection.close()
      }
    }
    return resultSet
  }

  def ExecuteQuery[T](query:String): util.ArrayList[T] = {
    println("ExecuteQuery")
    var resultSet : ResultSet = null;
    var list : util.ArrayList[T] = new util.ArrayList[T]()
    try {
      resultSet = this.CreateCommand(query)
      print("resultSet = "+ resultSet)
      val i = 1
      while ( resultSet.next() ) {
        val itemObject = resultSet.getObject(i)
        var item : T = itemObject.asInstanceOf[T]
        list.add(item)
      }
    } catch {
      case e => e.printStackTrace
    }
    return list
  }

}
