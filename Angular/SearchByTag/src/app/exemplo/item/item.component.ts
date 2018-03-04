import { Component, OnInit,Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent implements OnInit {

  private newItem: string; 
  @Output() outputItem = new EventEmitter();
  constructor() { }

  ngOnInit() {
  }

  onOutputMethod(event) {
    this.outputItem.emit(this.newItem);
  }
}
