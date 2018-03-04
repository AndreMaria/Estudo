import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { SubjectMatter } from './subject-matter.model';
import { Label } from './label/label.model';
import { Tag } from './tag/Tag.model';
import { ServiceService } from './service.service';
import { SubjectMatterView } from './subject-matter-view.model'

@Component({
  selector: 'app-subject-matter',
  templateUrl: './subject-matter.component.html',
  styleUrls: ['./subject-matter.component.css'],
  providers: [ServiceService]
})
export class SubjectMatterComponent implements OnInit {

  private formSubjectMatter: FormGroup;
  private smView: SubjectMatterView;
  private label: Label;
  private alertType: string;
  private message: string;
  private listTag: Array<Tag>;
  private textLabel: string = 'Ola!';

  constructor(private formBuilder: FormBuilder, private service: ServiceService) { 
    this.smView = new SubjectMatterView();
    this.smView.Tags = new Array<string>();
  }

  ngOnInit() {
    debugger;
    this.validate();
  }

  validate(){
    this.formSubjectMatter = this.formBuilder.group({
      Content : ['', Validators.required]
    });
  }

  Save(){
    if(!this.formSubjectMatter.invalid){
      
      let response = this.service.PostSubectMatter(this.smView);

      this.alertType = 'alert alert-success';
      this.message = "OK";
    } else {
      this.alertType = 'alert alert-danger';
      this.message = "Error";
    }
  }

  onTagAlize(event){
    if(event){
      this.listTag = event;
      this.textLabel = this.listTag[0].SimpleText;
      this.smView.Label = this.listTag[0].SimpleText;
    }
  }
}
