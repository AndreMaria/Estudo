var page = require('../../../pages/pages');
var consultaFaturamentoPage = require('../../../pages/faturamento/consulta-faturamento-page');

module.exports = function () {

  this.setDefaultTimeout(60 * 1000);
  this.World = require('../../support/world').World;

  this.Then(/^devo ver ([^"]*) guia consultada$/, function (valor) {
    return Promise.all([
      this.expect(consultaFaturamentoPage.status().getText()).to.eventually.be.equal(`${valor} resultado encontrado`)
    ]);
  });

  this.Then(/^devo ver ([^"]*) (\d+) a\(s\) guia\(s\) consultada\(s\)$/, function (valor) {
    return Promise.all([
      this.expect(consultaFaturamentoPage.status().getText()).to.eventually.be.equal(`${valor} resultados encontrados`)
    ]);
  });

  this.Then(/^não devo ver as guias consultadas$/, function () {
    return Promise.all([
        this.expect(consultaFaturamentoPage.NaoEncontrado().getText()).to.eventually.be.equal('Nenhum Resultado Encontrado.')
    ]);
  });

  this.Given(/^preenchi o campo ([^"]*) e seu valor ([^"]*)$/, function (tipoData,valor) {
    consultaFaturamentoPage.dataPersonalizado(tipoData, valor);
  });

  this.Given(/^preenchi o campo Identificador: ([^"]*)$/, function (identificador) {
    consultaFaturamentoPage.identificador(identificador);
  });

}
