var page = require('../../../../pages/pages');
var consultaFaturamentoPage = require('../../../../pages/faturamento/consulta-faturamento-page');

module.exports = function () {

  this.setDefaultTimeout(60 * 1000);
  this.World = require('../../../support/world').World;

  this.Given(/^cliquei em ([^"]*) no grid de resultados$/, function (opcao) {
    consultaFaturamentoPage.clickButtonNaGridDetalhe(opcao);
  });

  this.Then(/^devo visualizar o detalhe do protocolo$/, function () {
    return Promise.all([
        this.expect(consultaFaturamentoPage.visualizarDetalhe().getText()).to.eventually.be.equal('Detalhes protocolo')
    ]);
  });

  this.Then(/^selecionei o item ([^"]*)$/, function (opcao) {
    consultaFaturamentoPage.selecionarRadio(opcao)
  });

  this.Then(/^devo visualizar as guias relacionadas$/, function () {
    return Promise.all([
      this.expect(consultaFaturamentoPage.porColuna('Numero da Guia').getText()).to.eventually.deep.equal('12098458'),
      this.expect(consultaFaturamentoPage.porColuna('Nome do Beneficiário').getText()).to.eventually.deep.equal('MARTA MARIA DE JESUS ALVES'),
      this.expect(consultaFaturamentoPage.porColuna('Data de Atendimento').getText()).to.eventually.deep.equal('22/01/2018'),
      this.expect(consultaFaturamentoPage.porColuna('Conselho Profissional').getText()).to.eventually.deep.equal('CRM'),
      this.expect(consultaFaturamentoPage.porColuna('Tipo').getText()).to.eventually.deep.equal('SP/SADT'),
      this.expect(consultaFaturamentoPage.porColuna('Qtd Itens').getText()).to.eventually.deep.equal('1'),
      this.expect(consultaFaturamentoPage.porColuna('Valor Informado da Guia (R$)').getText()).to.eventually.deep.equal('0,00')
    ]);
  });
}
