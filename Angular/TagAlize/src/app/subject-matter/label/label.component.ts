import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { Label } from './label.model';
import { Tag } from '../tag/Tag.model';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-label',
  templateUrl: './label.component.html',
  styleUrls: ['./label.component.css'],
  providers: [ServiceService]
})
export class LabelComponent implements OnInit {

  private label: Label;

  @Input() formSubjectMatter: FormGroup;
  @Input() labelControl: string;
  @Output() createTag = new EventEmitter();

  constructor(private formBuilder: FormBuilder, private service: ServiceService) {
    this.label = new Label();
  }

  ngOnInit() {
    this.validate();
  }

  validate() {
    if (!this.formSubjectMatter.controls[this.labelControl]) {
      this.formSubjectMatter.addControl(this.labelControl, new FormControl());
    }
    this.formSubjectMatter.controls[this.labelControl].setValidators(
      [Validators.required, Validators.max(500), Validators.min(3)]
    );
  }

  onTagAlize(event) {
    let list: Array<Tag> = new Array<Tag>();
    let result =  this.service.GetTagAlize(this.formSubjectMatter.controls[this.labelControl].value);
    result.then((response) => {
      if (response) {
        for (let index = 0; index < response.Items.length; index++) {
          const element = response.Items[index];
          const tag: Tag = new Tag();
          tag.simpleText = element.Tag;
          tag.normalized = element.Normalized;
          list.push(tag);
        }
        this.createTag.emit(list);
      }
    }).catch((erro) => {
      this.createTag.emit(erro);
    });
  }
}
