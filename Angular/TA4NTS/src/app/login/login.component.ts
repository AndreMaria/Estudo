import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

import { Login } from './login';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [LoginService]
})
export class LoginComponent implements OnInit {

  private formLogin: FormGroup;
  private email: string;
  private senha: string;
  mensagem: string;

  constructor(private formBuilder: FormBuilder , private service: LoginService) { }

  ngOnInit() {
    this.validarForms();
  }

  private validarForms() {
      this.formLogin = this.formBuilder.group({
        email: ['', [Validators.required]],
        senha: ['', [Validators.required]]
      });
  }

  isInvalid(field: string, validate: string) {
    const fieldControl = this.formLogin.controls[field];
    return (fieldControl.touched) && (this.formLogin.hasError(validate)
      || ((validate) ? (fieldControl.hasError(validate)) : fieldControl.invalid));
  }

  metodoSend() {
    if (this.formLogin.valid) {
      const login: Login = new Login();
      login.Email = this.email;
      login.Senha = this.senha;
      const response = this.service.getLogin(login);
    } else {
      this.mensagem = 'Form Invalido!';
    }
  }

}
