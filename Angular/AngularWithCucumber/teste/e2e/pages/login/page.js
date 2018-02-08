var protractor = require('protractor');
var browser = protractor.browser;

class Page {

  constructor() {
    this.properties = ['no', 'entrar', 'preencher', 'verificar', 'abrir', 'by', 'buscar', 'clicar', 'identificar',
    'selecionar', 'contem', 'novo', 'esta']

    for(let prop of this.properties){
      this[prop] = this;
    }
  }

  site(url) {
    browser.get(`${browser.baseUrl}${url}`);
  }

  texto(mensagem) {
    return element(by.xpath(`.//*[.=${mensagem}]`));
  }

  id(identificador) {
    return element(by.id(identificador));
  }

  css(query) {
    return element.all(by.css(query));
  }

  botao(nome) {
    element.all(by.buttonText(nome)).first().click();
  }

  label(label, dado) {
    return element(by.xpath(`//label[.='${label}']/following::input[1]`)).clear().sendKeys(dado);
  }

}
 module.exports = Page
