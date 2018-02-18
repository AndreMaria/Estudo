import { Component, OnInit, Output, EventEmitter } from '@angular/core';

import { Label } from './label';

@Component({
  selector: 'app-label',
  templateUrl: './label.component.html',
  styleUrls: ['./label.component.css']
})
export class LabelComponent implements OnInit {

  private label: Label;
  @Output() createLabel = new EventEmitter();  
  constructor() {  this.label = new Label()}

  ngOnInit() {
  }

  onCreateLabel(event) {
    debugger;
    this.createLabel.emit(this.label)
  }
}
