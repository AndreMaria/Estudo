package Map

/**
 * Created by AndreMaria on 04/12/2017.
 */

case class Texto(word: String, length: Int)

object Mapping extends {

  def splitMaxText(field: String): Array[Texto] = {
    val arrayCampo = field.split(" ")
    val arrayText : Array[Texto] = new Array[Texto](arrayCampo.length);
    var i = 0
    arrayCampo.foreach(
      x => {
        arrayText(i) = new Texto(x.toString(), x.length())
        i += 1
      }
    )
    return arrayText
  }

  def listParagraph(field: String,paragraphLegngth :Int): Array[String] = {

    var array = splitMaxText(field)
    var quant = field.length/paragraphLegngth
    if(field.length%paragraphLegngth > 0){quant += 1}

    var count = quant
    val paragraphList : Array[String] = new Array[String](quant)
    var paragraph : String = " "
    var rest : String = " "
    var i = 0
    array.foreach(x=> {
      if(paragraph.length + x.length < paragraphLegngth){
        paragraph = String.format("%s %s ", paragraph, x.word)
      }
      else if(paragraph.length + x.length > paragraphLegngth){
        var subLength = paragraph.length + x.length - paragraphLegngth
        var sub : String = ""
        if (x.length > subLength){
          sub =  x.word.substring(0,subLength)
          rest = " " + x.word.substring(subLength,x.length)
        }
        else{
          sub = x.word
        }
        paragraph = String.format("%s %s ", paragraph, sub)
        paragraphList(i) = paragraph
        paragraph = rest;
        rest = " "
        i += 1
        count -= 1
      }
    })

    if(count == 1){
      paragraphList(quant-1) = paragraph
    }

    return paragraphList
  }
}
