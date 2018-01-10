package repository

import java.sql.ResultSet

import model.{usuario}
/**
 * Created by AndreMaria on 03/01/2018.
 */
object usuarioRepository {

  def select(query: String, params : Option[Seq[Any]]): Seq[usuario] = {
    val rp = new repository()
    val rs = rp.executeQuery(query,params)

    val result = rp.execute[usuario]( F => {
        usuario(rs.getInt("id"),rs.getString("user_name"),rs.getString("user_email"),rs.getString("login"),"")
    }
    ,rs)
    if(null != rs){
      rs.close()
    }
    return result
  }
}
