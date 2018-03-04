import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-exemplo',
  templateUrl: './exemplo.component.html',
  styleUrls: ['./exemplo.component.css']
})
export class ExemploComponent implements OnInit {

  private alert: string;
  private typeAlert: string;
  private newExemplo: string;
  constructor() { }

  ngOnInit() {
  }

  onOutputMethodInExample(event) {
    this.alert = event;
    if(event) {
      this.typeAlert = "alert alert-warning"

    } else {
      this.alert = `[Warning]: O campo New Item é obrigatório!`;
      this.typeAlert = "alert alert-danger"
    }
  }

  onSave() {
    if(this.newExemplo && this.alert) {
      this.typeAlert = "alert alert-success"
      this.alert = `[Success]:${this.newExemplo} (${this.alert})`;
    }  else if(!this.alert && this.newExemplo) {
      this.alert = `[Warning]: O campo New Item é obrigatório!`;
      this.typeAlert = "alert alert-danger"
    }else if(this.alert && !this.newExemplo) {
      this.alert = `[Warning]: O campo New Example é obrigatório!`;
      this.typeAlert = "alert alert-danger"
    }else {
      this.alert = `[Warning]: Os campos (New Example) e (New Item) são obrigatórios!`;
      this.typeAlert = "alert alert-danger"
    }
  }
}

