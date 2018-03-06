'use strict';

const Page = require('../../pages/pages');

class ConsultaFaturamentoPage extends Page {

    constructor() {
        super();
    }

    status() {
      //return this.css(query);
      return this.buscar.by.css('as-consulta .contador-consulta').first();
    }

    NaoEncontrado() {
      return this.buscar.by.css('as-consulta .resultado-aviso-filtro').first();
    }

    dataPersonalizado(label, dado) {
      return element(by.xpath(`//label[.='${label}']/following::input[1]`)).clear().sendKeys(dado);
    }

    clickButtonNaGridDetalhe(label) {
      element(by.xpath(`//td/following::button[.='${label}']`)).click();
    }

    visualizarDetalhe() {
      return this.buscar.by.css('modal modal-header h2').first();
    }

    selecionarRadio(opcao) {
      element(by.xpath(`//label[.='${opcao}']`)).click();
    }

    porColuna(titulo) {
      return element(by.css(`*[aria-label='${titulo}']`));
    }

    identificador(numero) {
      this.preencher.by.label('Identificador', numero);
    }
}

module.exports = new ConsultaFaturamentoPage();
