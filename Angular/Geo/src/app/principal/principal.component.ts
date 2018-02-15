import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { Principal } from './principal';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css']
})
export class PrincipalComponent implements OnInit {

  private formPrincipal: FormGroup;
  private mensagem: string;
  private principal: Principal;

  constructor(private formBuilder: FormBuilder) {
    this.principal = new Principal();
  }

  ngOnInit() {
    this.isValidate();
  }

  isValidate() {
    this.formPrincipal = this.formBuilder.group({
      Id: ['', Validators.required],
      Texto: ['', Validators.required],    });
  }

  validatePrincipal() {
    if (!this.formPrincipal.invalid) {
      this.mensagem = 'OK';
    } else {
      this.mensagem = 'Os campos são obrigatórios!';
    }
  }
}
