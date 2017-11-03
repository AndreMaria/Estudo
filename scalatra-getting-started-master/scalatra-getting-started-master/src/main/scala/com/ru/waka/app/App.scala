package com.ru.waka.app

import org.json4s.{DefaultFormats, Formats}
import org.scalatra.json._

class App extends AppStack with JacksonJsonSupport {
  protected implicit val jsonFormats: Formats = DefaultFormats.withBigDecimal

  get("/") {
    com.ru.waka.html.index.render()
  }

  get("/json") {
    contentType = formats("json")
    App.Hoge("aaa")
  }
}

object App {
  case class Hoge(a: String)
}
