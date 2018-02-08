
const Page = require('./page')

class LoginPage extends Page {

  constructor(){
    super();
  }

  dados(dados){
    this.preencher.by.label('Email',dados.email);
    this.preencher.by.label('Password',dados.password);
  }

  login() {
    this.clicar.no.botao('Entrar')
  }

  negado() {
    return this.buscar.by.css('app-login form div p').first()
  }

}

module.exports = new LoginPage();
