import { browser, by, element } from 'protractor';

export class AppPage {

  public properties: Array<any>;
  constructor() {
    this.properties = ['no', 'entrar', 'preencher', 'verificar', 'abrir', 'by', 'buscar', 'clicar', 'identificar',
    'selecionar', 'contem', 'novo', 'esta'];

    this.properties.forEach( x => this[x] = this);
  }

  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('app-root h1')).getText();
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
}
