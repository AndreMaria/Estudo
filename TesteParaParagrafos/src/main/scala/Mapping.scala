/**
 * Created by AndreMaria on 05/12/2017.
 */

case class texto(word: String, length: Int)

object Mapping extends {

  def splitMaxText(field: String): Array[texto] = {
    val arrayCampo = field.split(" ")
    val arrayText : Array[texto] = new Array[texto](arrayCampo.length);
    var i = 0
    arrayCampo.foreach(
      x => {
        arrayText(i) = new texto(x.toString(), x.length())
        i += 1
      }
    )
    return arrayText
  }

  def listParagraph(field: String,paragraphLegngth :Int): Array[String] = {
    var array = splitMaxText(field)
    val paragraphList : Array[String] = new Array[String](array.length/2)
    var paragraph : String = " "
    var rest : String = " "
    var i = 0
    array.foreach(x=> {
      if(paragraph.length + x.length < paragraphLegngth){
        paragraph = String.format("%s %s ", paragraph, x.word)
      }
      else if(paragraph.length + x.length > paragraphLegngth){
        var subLength = paragraph.length + x.length - paragraphLegngth
        var sub : String = x.word.substring(0,subLength)
        rest = x.word.substring(subLength,x.length - subLength)
        paragraph = String.format("%s %s ", paragraph, sub)

      }
      else {
        paragraphList(i) = paragraph
        paragraph = rest;
        rest = " "
      }
      i += 1
    })
    return paragraphList
  }
}