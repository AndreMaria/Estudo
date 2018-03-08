import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators} from '@angular/forms';

import { Tag } from './Tag.model';
import { ServiceService } from '../service.service';
import { SubjectMatterView } from '../subject-matter-view.model';

@Component({
  selector: 'app-tag',
  templateUrl: './tag.component.html',
  styleUrls: ['./tag.component.css'],
  providers: [ServiceService]
})
export class TagComponent implements OnInit {

  private textTag: string;
  @Input() listTag: Array<Tag>;
  @Input() textLabel: string;
  @Input() formSubjectMatter: FormGroup;
  @Input() tagControl: string;
  @Input() smView: SubjectMatterView;

  constructor(private service: ServiceService) { }

  ngOnInit() {
    this.validate();
  }

  validate() {
    if (!this.formSubjectMatter.controls[this.tagControl]) {
      this.formSubjectMatter.addControl(this.tagControl, new FormControl());
    }
    this.formSubjectMatter.controls[this.tagControl].setValidators([Validators.max(500), Validators.min(3)] );
  }

  onTagAlize(event) {
    if (this.textTag) {
      this.smView.Tags.push(this.textTag);
      this.service.GetTagAlize(this.textTag).then((response) => {
        if (response) {
          for (let index = 0; index < response.Items.length; index++) {
            const element = response.Items[index];
            const tag: Tag = new Tag();
            tag.simpleText = element.Tag;
            tag.normalized = element.Normalized;
            this.listTag.push(tag);
          }
        }
      });
    }
    if (this.textLabel) {
      this.service.GetTagAlize(this.textLabel).then((response) => {
        if (response) {
          for (let index = 0; index < response.Items.length; index++) {
            const element = response.Items[index];
            const tag: Tag = new Tag();
            tag.simpleText = element.Tag;
            tag.normalized = element.Normalized;
            this.listTag.push(tag);
          }
        }
      });
    }
  }
}
