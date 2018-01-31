import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  private formLogin: FormGroup;
  private campo_para_validar: string;
  mensagem: string;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.validarForms();
  }

  private validarForms() {
      this.formLogin = this.formBuilder.group({
          campo_para_validar: ['', [Validators.required]]
      });
  }

  isInvalid(field: string, validate: string) {
    const fieldControl = this.formLogin.controls[field];
    return (fieldControl.touched) && (this.formLogin.hasError(validate)
      || ((validate) ? (fieldControl.hasError(validate)) : fieldControl.invalid));
  }

  metodoSend() {
    if (this.formLogin.valid) {
      this.mensagem = 'Form OK';
    } else {
      this.mensagem = 'Form Invalido!';
    }
  }

}
