'use strict';

var loginPage = require('../../pages/login/login-page');
var loginTempalte = require('../../fixture/login/login-template');

var chai = require('chai');
var chaiAsPromised = require('chai-as-promised');

chai.use(chaiAsPromised);
var expect = chai.expect;

module.exports = function() {

  //this.setDefaultTimeout(60 * 1000);

  this.Given(/^que informei o login usando <situacao>$/, {timeout: 60 * 1000}, function () {
    loginPage.entrar.no.site('/');
    var login = loginTempalte.get['valido'];
    loginPage.dados(login);
    loginPage.login();
  });

  this.Then(/^o site <resultado> a home logada$/, function(done) {
    expect(loginPage.negado().getText()).to.eventually.be.equal('OK').and.notify(done);
  });

};
