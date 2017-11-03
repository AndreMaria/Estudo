package com.ru.waka.app.repository

import java.util

import com.ru.waka.app.model.Usuario
import com.ru.waka.app.rest.RestClient.Get
import com.ru.waka.app.rest.Response

import scala.concurrent.{ExecutionContext, Future, Promise}

class UsuarioRepository extends BaseSql {

  lazy val pathUrl = sys.env.get("tutorial.api.url")
  private lazy val headers = Map("Accept" -> "application/vnd.amil.credenciado.medico.pedido.autorizacao.v1+json", "Content-Type" -> "application/json")

  def GetAllUsers() : util.ArrayList[Usuario] = {
    println("GetAllUsers")
    var list = this.ExecuteQuery[Usuario]("SELECT * FROM Usuario")
    return  list;
  }

  def buscarUsuarios(numeroPedido: String, sequencia: Long): Future[Option[List[Usuario]]] = {
    val result: Future[Response] = Get(uri = s"$pathUrl/usuarios/GetAllUsuario", headers = headers)
    result.map(json => Some(json.body.fromJson[List[Usuario]]))
      .recover(null)
  }
}
