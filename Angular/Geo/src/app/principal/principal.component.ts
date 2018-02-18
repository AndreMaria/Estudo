import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { Principal } from './principal';
import { PrincipalService } from './principal.service';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css'],
  providers: [PrincipalService]
})
export class PrincipalComponent implements OnInit {

  private formPrincipal: FormGroup;
  private mensagem: string;
  private status: boolean;
  private principal: Principal;

  constructor(private formBuilder: FormBuilder, private service: PrincipalService) {
    this.principal = new Principal();
  }

  ngOnInit() {
    this.isValidate();
  }

  isValidate() {
    this.formPrincipal = this.formBuilder.group({
      Texto: ['', Validators.required]});
  }

  validatePrincipal() {
    if (!this.formPrincipal.invalid) {
      this.service.Save(this.principal)
      this.mensagem = 'OK';
      this.status = true;
    } else {
      this.mensagem = 'Os campos são obrigatórios!';
    }
  }
}
