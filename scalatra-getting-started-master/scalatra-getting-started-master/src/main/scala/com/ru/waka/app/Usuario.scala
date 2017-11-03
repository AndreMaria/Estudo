package com.ru.waka.app

import org.scalatra.AsyncResult

import scala.concurrent.{ExecutionContext, Future, Promise}
import scala.util.{Failure, Success, Try}
import org.json4s._
import org.scalatra.json._
import org.jboss.netty.handler.codec.http.{HttpRequest, HttpResponse, HttpResponseStatus}
import scala.concurrent.Await

import scala.concurrent._
import ExecutionContext.Implicits.global
import scala.concurrent.duration.Duration

class Usuario extends AppStack with JacksonJsonSupport {
  protected implicit val jsonFormats: Formats = DefaultFormats.withBigDecimal

  get("/item"){
    contentType = formats("json")
    List(HttpClient.getUsuarios())
  }

  /*
  get("/usuarios"){
    println("Entrou")
    contentType = formats("json")
    var items = Await HttpClient.GetClientString();
    println("Itens:" + items);
    new AsyncResult {
      val is = {
        HttpClient.GetClientString()
      }
      println("valor de is:" + is)
    }
  }
  */

  get("/usuarios") {
    contentType = formats("json")
    println("Usuarios")

    var list : List[Usuario.UsuarioDto] = null
    val intFuture: Future[_] = HttpClient.GetClientString()

    intFuture onComplete {
      case Success(t) =>
      {
        println("Sucesso")
        list = parse(t.toString()).extract[List[Usuario.UsuarioDto]]
      }
      case Failure(e) =>
      {
        println(s"An error has occured: $e.getMessage")
      }
    }
    var index : Int = 0;
    while (list == null){
      Thread.sleep(10)
      index = index + 1
      println("Ainda nao [:(][index]:" + index )
    }
    List(list)
  }
}

object Usuario {
  case class UsuarioDto(Id: Int, Nome: String, Senha :String, Email :String)

}

object HttpClient {
  import dispatch.{Http,url,as}
  println("HttpClient")
  def GetClientString()(implicit ctx: ExecutionContext):Future[String] = {
    println("GetClientString")
    val prom = Promise[String]()
    dispatch.Http(url("http://localhost:54219/api/usuarios/GetAllUsuario") OK as.String) onComplete {
      case Success(content) =>
      {
        Right(content)
        println("Conteudo:" + content)
        prom.complete(Try(content.toString()))
      }
      case Failure(exception) => println("erro:" + exception)
    }
    prom.future
  }
  def getUsuarios(): Array[Usuario.UsuarioDto] ={

    var myArray : Array[Usuario.UsuarioDto] = new Array[Usuario.UsuarioDto](10);
    myArray(0) = Usuario.UsuarioDto(1,"Andre Maria","andre.maria","andremaria1980@gmail.com")
    myArray(1) = Usuario.UsuarioDto(2,"Andre Maria","andre.maria","andremaria1980@gmail.com")
    return myArray
  }
}

