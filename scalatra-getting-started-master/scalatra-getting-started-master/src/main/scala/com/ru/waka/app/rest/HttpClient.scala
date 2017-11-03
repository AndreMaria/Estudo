package com.ru.waka.app.rest

import dispatch.{Http, as, url}
import scala.concurrent.{ExecutionContext, Future, Promise}
import scala.util.{Failure, Success, Try}

class HttpClient {

  def GetClientString(urlSite:String)(implicit ctx: ExecutionContext):Future[String] = {
    val prom = Promise[String]()
    dispatch.Http(url(urlSite) OK as.String) onComplete {
      case Success(content) =>
      {
        Right(content)
        prom.complete(Try(content.toString()))
      }
      case Failure(exception) => println("erro:" + exception)
    }
    prom.future
  }
}

object RestClient {

  def execute(request: Req)(implicit ctx: ExecutionContext): Future[Response] = {
    log.debug(RequestPrinter(RequestImpl(request.toRequest)).toString);
    httpClient(request.OKWithResponse[Response](r => ResponseImpl(r)))
  }

  def Get(uri: String, params: Traversable[(String,String)] = Map[String,String](), headers: Traversable[(String,String)] = Map[String,String]())(implicit ctx: ExecutionContext): Future[Response] = {
    execute(url(uri) <<? params <:< headers)
  }

}

trait Response {
  def uri: String
  def body: String
  def bodyAsBytes: Array[Byte]
  def header(name: String): String
  def statusCode: Int
  def headers: Array[String]
}

trait Request {
  def headers: Array[String]
  def bodyEncoding: String
  def getMethod: String
  def getStringData: String
  def getUrl: String
}

case class ResponseImpl(response: NingResponse) extends Response {

  private val charsetPattern = ".+?charset=([^;]+)[.+]?".r

  private def getCharset: String = response.getContentType match {
    case charsetPattern(encoding) => encoding
    case _ => RestParameters.charset
  }
  def body: String = response.getResponseBody(getCharset)
  def bodyAsBytes: Array[Byte] = response.getResponseBodyAsBytes
  def header(name: String) = response.getHeader(name)
  def headers = response.getHeaders.entrySet.asScala.map(entry => s"${entry.getKey} -> ${entry.getValue}").toArray
  def statusCode = response.getStatusCode
  def uri = response.getUri.toString
}

case class RequestImpl(request: NingRequest) extends Request {
  def headers = request.getHeaders.entrySet.asScala.map(entry => s"${entry.getKey} -> ${entry.getValue}").toArray
  def bodyEncoding = request.getBodyEncoding
  def getMethod = request.getMethod
  def getStringData = request.getStringData
  def getUrl = request.getUrl
}
