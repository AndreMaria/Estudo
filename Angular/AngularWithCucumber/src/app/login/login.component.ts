import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { Login } from './login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  private fromLogin: FormGroup;
  private email: string;
  private password: string;
  private mensagem: string;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.isValidate();
  }

  isValidate() {
    this.fromLogin = this.formBuilder.group( {
      email: ['email', Validators.required],
      password: ['password', Validators.required]
    });
  }

  isInvalid(field: string, validate: string) {
    const fieldControl = this.fromLogin.controls[field];
    return (fieldControl.touched) &&
    (this.fromLogin.hasError(validate) || (validate) ? this.fromLogin.hasError(validate) : fieldControl.invalid );
  }

  isLoginValidate() {
    const login: Login = new Login();
    if (!this.fromLogin.invalid) {
      login.Email = this.email;
      login.Password = this.password;
      this.mensagem = 'OK';
    } else {
      this.mensagem = 'Os campos são obrigatórios!';
    }
  }

  Cancel() {
    this.email = '';
    this.password = '';
  }

}
