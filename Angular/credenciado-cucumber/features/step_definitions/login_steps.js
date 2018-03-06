'use strict';
var { Given, When, Then } = require('cucumber');
var login = require('../../pages/login-page');

var protractor = require('protractor')
var browser = protractor.browser;
//var loginTemplate = require('../../fixture/login-template')

var chai = require('chai');
//var chaiAsPromised = require('chai-as-promised');

//chai.use(chaiAsPromised);
var expect = chai.expect;

Given(/^I go to "([^"]*)"$/, function (site) {
  console.log("Vai Corinthians");
  browser.get('http://dev.credenciado.amil.com.br:3000/');
});
/*
When(/^I add "([^"]*)" in the type field and add "([^"]*)" in the name field$/, function (type,name) {
  console.log("[log]:Entrou");
  var values = loginTemplate.get[type][name];
  login.dados(values);
});

When(/^I click the add button$/, function () {
  login.clicar.no.login();
});

Then(/^I should see my new task in the list$/, function (done) {
  expect(login.negado().getText()).to.eventually.be.equal('OK').and.notify(done);
});
*/
