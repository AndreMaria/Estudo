import { Component, OnInit } from '@angular/core';

import { Main } from './main';
import { Label } from './label/label';
import { Tag } from './tag/tag';
import { ServiceService } from './service.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css'],
  providers: [ServiceService]
})
export class MainComponent implements OnInit {

  private main: Main
  private labels: Array<Label>;
  private tags: Array<Tag>;
  constructor(private service: ServiceService) {  this.main = new Main();}

  ngOnInit() {
    this.labels = new Array<Label>();
    this.tags = new Array<Tag>();
  }

  onCreateLabel(event) {
    debugger;
    let label : Label = new Label();
    label.Category = event.Category;
    label.Text = event.Text;

    this.labels.push(label);

    this.service.getTagAlize(label.Category + ' ' + label.Text).then((result)=>{
      if(result){
        for (let index = 0; index < result.length; index++) {
          const element = result[index];
          let tag : Tag = new Tag();
          tag.Item = element.Tag;
          tag.Normalized = element.Normalized;
          this.tags.push(tag);
        }
      }
    }).catch((erro)=>{ console.log(erro)});
  }

  onCreateTag(event) { 
    for (let index = 0; index < event.length; index++) {
      const element = event[index];
      let tag : Tag = new Tag();
      tag.Item = element.Tag;
      tag.Normalized = element.Normalized;
      this.tags.push(tag);
    }
    console.log(event);
  }

  onSave() {
    if(this.main) {
      this.main.Labels = this.labels;
      this.main.Tags = this.tags;
      this.service.onSave(this.main);
    }
  }
}
