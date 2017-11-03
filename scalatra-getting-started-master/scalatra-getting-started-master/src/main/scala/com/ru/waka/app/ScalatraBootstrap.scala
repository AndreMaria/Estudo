package com.ru.waka.app

import javax.servlet.ServletContext
import org.scalatra._
import com.ru.waka.app.service.{UsuarioService}

class ScalatraBootstrap extends LifeCycle {
  override def init(context: ServletContext) {
    context.mount(new App, "/*")
    //context.mount(new Usuario,"/usuario/*")
    context.mount(new UsuarioService,"/user/*")
  }
}
