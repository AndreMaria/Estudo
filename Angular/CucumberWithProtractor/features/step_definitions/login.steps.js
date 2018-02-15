
  var { Given, When, Then }  = require('cucumber');
  var login = require('../../pages/login-page');
  var loginTemplate = require('../../fixture/login-template');

  var chai = require('chai');
  var chaiAsPromised = require('chai-as-promised');

  chai.use(chaiAsPromised);
  var expect = chai.expect;

  Given(/^I go to "([^"]*)"$/, function (string) {
    login.entrar.no.site(string);
  });


  When(/^I add "([^"]*)" in the type field and add "([^"]*)" in the name field$/, function (type, name) {
    // Write code here that turns the phrase above into concrete actions
    var values = loginTemplate.get[type][name];
    login.dados(values);
  });


  When(/^I click the add button$/, function () {
    login.clicar.no.login();
  });


  Then(/^I should see my new task in the list$/, function (done) {
    expect(login.negado().getText()).to.eventually.be.equal('OK').and.notify(done);
  });

