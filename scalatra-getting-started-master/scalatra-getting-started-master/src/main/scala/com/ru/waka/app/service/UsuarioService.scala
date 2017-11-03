package com.ru.waka.app.service

import com.ru.waka.app.{AppStack, HttpClient, Usuario}
import com.ru.waka.app.rest.HttpClient

import scala.concurrent.{ExecutionContext, Future, Promise}
import org.scalatra.AsyncResult

import scala.util.{Failure, Success, Try}
import org.json4s._
import org.scalatra.json._
import com.ru.waka.app.repository.UsuarioRepository

import ExecutionContext.Implicits.global

class UsuarioService extends AppStack with JacksonJsonSupport {
  protected implicit val jsonFormats: Formats = DefaultFormats.withBigDecimal

  get("/AllUsers") {
    contentType = formats("json")
    var httpClient = new HttpClient()
    var list : List[com.ru.waka.app.model.Usuario] = null
    new AsyncResult {
      val is : Future[_] = httpClient.GetClientString("http://localhost:54219/api/usuarios/GetAllUsuario")

      is onComplete {
        case Success(t) =>
        {
          list = parse(t.toString()).extract[List[com.ru.waka.app.model.Usuario]]
        }
        case Failure(e) =>
        {
          println(s"An error has occured: $e.getMessage")
        }
      }
      while (list == null){
        Thread.sleep(10)
      }
    }
    List(list)
  }

  get("/SqlAllUsers") {
    println("SqlAllUsers")
    contentType = formats("json")
    var repository = new UsuarioRepository()
    var itens = repository.GetAllUsers()
    List(itens)
  }

  get("/otherAllUsers") {
    contentType = formats("json")
    var repository = new UsuarioRepository()
    //repository.buscarUsuarios()
  }

}
