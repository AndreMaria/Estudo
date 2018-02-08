import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  private formlogin: FormGroup;
  private email: string;
  private password: string;
  private mensagem: string;
  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.isValidate();
  }

  isValidate() {
    this.formlogin = this.formBuilder.group({
      email: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  isInvaled(field: string, validate: string) {
    const fieldControl = this.formlogin.controls[field];
    return fieldControl.touched &&
      (this.formlogin.hasError(validate) || (validate) ? fieldControl.hasError(validate) : fieldControl.invalid);
  }

  validateLogin() {
    if (!this.formlogin.invalid) {
      this.mensagem = 'OK';
    } else {
      this.mensagem = 'Os campos são obrigatórios!';
    }
  }
}
