import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { Tag } from './tag';

@Component({
  selector: 'app-tag',
  templateUrl: './tag.component.html',
  styleUrls: ['./tag.component.css']
})
export class TagComponent implements OnInit {

  private formTag: FormGroup;
  private mensagem: string;
  private status: boolean;
  private tag: Tag;

  constructor(private formBuilder: FormBuilder) {
    this.tag = new Tag();
  }

  ngOnInit() {
    this.isValidate();
  }

  isValidate() {
    this.formTag = this.formBuilder.group({
      Id: ['', Validators.required],
      Idprincipal: ['', Validators.required],
      Tagtexto: ['', Validators.required],
      Tagnormalized: ['', Validators.required],    });
  }

  validateTag() {
    if (!this.formTag.invalid) {
      this.mensagem = 'OK';
      this.status = true;
    } else {
      this.mensagem = 'Os campos são obrigatórios!';
    }
  }

}
