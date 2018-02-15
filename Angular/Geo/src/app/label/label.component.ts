import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { Label } from './label';

@Component({
  selector: 'app-label',
  templateUrl: './label.component.html',
  styleUrls: ['./label.component.css']
})
export class LabelComponent implements OnInit {

  private formLabel: FormGroup;
  private mensagem: string;
  private label: Label;

  constructor(private formBuilder: FormBuilder) {
    this.label = new Label();
  }

  ngOnInit() {
    this.isValidate();
  }

  isValidate() {
    this.formLabel = this.formBuilder.group({
      Id: ['', Validators.required],
      Idprincipal: ['', Validators.required],
      Texto: ['', Validators.required],
      Category: ['', Validators.required],    });
  }

  validateLabel() {
    if (!this.formLabel.invalid) {
      this.mensagem = 'OK';
    } else {
      this.mensagem = 'Os campos são obrigatórios!';
    }
  }

}
