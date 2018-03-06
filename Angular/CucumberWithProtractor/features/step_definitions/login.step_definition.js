
  var { Given, When, Then }  = require('cucumber');
  var loginPage = require('../../pages/login-page');
  var loginTemplate = require('../../fixture/login-template');

  var chai = require('chai');
  var chaiAsPromised = require('chai-as-promised');

  chai.use(chaiAsPromised);
  var expect = chai.expect;

  Given(/^I go to "([^"]*)"$/, function (string) {
    console.log('Etrou porra');
    loginPage.entrar.no.site(string);
  });


  When(/^I add "([^"]*)" in the type field and add "([^"]*)" in the name field$/, function (type, name) {
    // Write code here that turns the phrase above into concrete actions
    var values = loginTemplate.get[type][name];
    loginPage.dados(values);
  });


  When(/^I click the add button$/, function () {
    loginPage.clicar.no.login();
  });


  Then(/^I should see my new task in the list$/, function (done) {
    expect(login.negado().getText()).to.eventually.be.equal('OK').and.notify(done);
  });

  Given(/^cliquei em ([^"]*) no grid de resultados$/, function (opcao) {
    consultaFaturamentoPage.clickButtonNaGridDetalhe(opcao);
  });

  Then(/^devo visualizar o detalhe do protocolo$/, function () {
    return Promise.all([
        expect(consultaFaturamentoPage.visualizarDetalhe().getText()).to.eventually.be.equal('Detalhes protocolo')
    ]);
  });

  Then(/^selecionei o item ([^"]*)$/, function (opcao) {
    consultaFaturamentoPage.selecionarRadio(opcao)
  });

  Then(/^devo visualizar as guias relacionadas$/, function () {
    return Promise.all([
      expect(consultaFaturamentoPage.porColuna('Numero da Guia').getText()).to.eventually.deep.equal('12098458'),
      expect(consultaFaturamentoPage.porColuna('Nome do Beneficiário').getText()).to.eventually.deep.equal('MARTA MARIA DE JESUS ALVES'),
      expect(consultaFaturamentoPage.porColuna('Data de Atendimento').getText()).to.eventually.deep.equal('22/01/2018'),
      expect(consultaFaturamentoPage.porColuna('Conselho Profissional').getText()).to.eventually.deep.equal('CRM'),
      expect(consultaFaturamentoPage.porColuna('Tipo').getText()).to.eventually.deep.equal('SP/SADT'),
      expect(consultaFaturamentoPage.porColuna('Qtd Itens').getText()).to.eventually.deep.equal('1'),
      expect(consultaFaturamentoPage.porColuna('Valor Informado da Guia (R$)').getText()).to.eventually.deep.equal('0,00')
    ]);
  });

  Then(/^devo ver ([^"]*) guia consultada$/, function (valor) {
    return Promise.all([
      expect(consultaFaturamentoPage.status().getText()).to.eventually.be.equal(`${valor} resultado encontrado`)
    ]);
  });

  Then(/^devo ver ([^"]*) (\d+) a\(s\) guia\(s\) consultada\(s\)$/, function (valor) {
    return Promise.all([
      expect(consultaFaturamentoPage.status().getText()).to.eventually.be.equal(`${valor} resultados encontrados`)
    ]);
  });

  Then(/^não devo ver as guias consultadas$/, function () {
    return Promise.all([
        expect(consultaFaturamentoPage.NaoEncontrado().getText()).to.eventually.be.equal('Nenhum Resultado Encontrado.')
    ]);
  });

  Given(/^preenchi o campo ([^"]*) e seu valor ([^"]*)$/, function (tipoData,valor) {
    consultaFaturamentoPage.dataPersonalizado(tipoData, valor);
  });

  Given(/^preenchi o campo Identificador: ([^"]*)$/, function (identificador) {
    consultaFaturamentoPage.identificador(identificador);
  });

  Given(/^que loguei como credenciado informando ([^"]*)$/, function (tipo, callback) {
    loginPage.entrar.no.site('/');
    login = loginTemplate.get['válido'][tipo];
    loginPage.preencher.dados(login);
    loginPage.login();
    expect(browser.getTitle()).to.eventually.equal('Portal do credenciado médico').and.notify(callback);
  });

  Given(/^que eu acessei a Home Page do sistema Portal do Credenciado Médico$/, function (done) {
    page.entrar.no.site('/');
    expect(browser.getTitle()).to.eventually.equal('Portal do credenciado médico').and.notify(done);
  });

  Then(/^visualizarei a presença do texto "([^"]*)"$/, function (texto, done) {
      expect(page.buscar.texto(texto).getText()).to.eventually.equal(texto).and.notify(done);
  });

  Given(/^(?:clico|cliquei|que cliquei|que clico) no link "([^"]*)"$/, function (texto, done) {
      page.clicar.no.link(texto);
      done();
  });

  Given(/^(?:clico|cliquei|que cliquei|que clico) no link ([^"]*)$/, function (texto, done) {
      page.clicar.no.link(texto);
      done();
  });

  Then(/^visualizarei a presença do botão "([^"]*)"$/, function (conteudo, done) {
      expect(element.all(by.buttonText(conteudo))).to.eventually.be.ok.and.notify(done);
  });

  Then(/^visualizarei a mensagem "([^"]*)"$/, function (texto, done) {
      expect(page.buscar.texto(texto).getText()).to.eventually.equal(texto).and.notify(done);
  });

  Given(/^(?:clico|cliquei) no botão "([^"]*)"$/, function (texto, done) {
      page.clicar.no.botao(texto);
      done();
  });

  When(/^(?:clico|cliquei) no botão ([^"]*)$/, function (texto, done) {
      page.clicar.no.botaoLink(texto);
      done();
  });

  Then(/^o caso de teste ([^"]*) será contemplado$/, function (texto, done) {
      done();
  });

  Then(/^visualizarei o campo ([^"]*) com borda vermelha$/, function (campo, done) {
      expect(page.buscar.comClasse(campo, 'ng-invalid').isPresent()).to.eventually.equal(true).and.notify(done);
  });

  Then(/^visualizarei a home logada do Portal do Credenciado Médico$/, function (done) {
      expect(browser.getCurrentUrl()).eventually.to.match(/\/home$/).and.notify(done);
  });

  Then(/^visualizarei a página ([^"]*)$/, function (nome, done) {
      expect(browser.getCurrentUrl()).to.eventually.contain(pagina[nome]).and.notify(done);
  });

  Then(/^visualizarei o texto "([^"]*)"$/, function (texto, done) {
      expect(page.buscar.texto(texto).getText()).to.eventually.equal(texto).and.notify(done);
  });

  Then(/^visualizarei no link ([^"]*) a presença da url "([^"]*)"$/, function (link, endereço, done) {
      expect(page.verificar.linkExterno(link).getAttribute('href')).to.eventually.equal(endereço).and.notify(done);
  });

  Then(/^visualizarei a imagem d[a|e|o] ([^"]*)$/, function (nome, done) {
      expect(page.verificar.imagem(nome)).eventually.to.contain(imagem[nome]).and.notify(done);
  });

  Given(/^selecionei no campo ([^"]*) o item ([^"]*)$/, function (campo, opcao) {
      page.clicar.selecionarRadio(campo, opcao)
  });

  Given(/^pause$/, function () {
      browser.pause();
  });
