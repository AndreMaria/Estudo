import { Component, OnInit } from '@angular/core';

import { Label } from '../../label/label';

@Component({
  selector: 'app-principal-label',
  templateUrl: './principal.label.component.html',
  styleUrls: ['./principal.label.component.css']
})
export class PrincipalLabelComponent implements OnInit {

  private label: Label;
  constructor() { this.label = new Label();}

  ngOnInit() {
  }

}
