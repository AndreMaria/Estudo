import { Component, OnInit, Output, EventEmitter } from '@angular/core';

import { ServiceService } from '../service.service';
import { TagAlize } from '../TagAlize';

@Component({
  selector: 'app-tag',
  templateUrl: './tag.component.html',
  styleUrls: ['./tag.component.css'],
  providers: [ServiceService]
})
export class TagComponent implements OnInit {

  private newTag: string;
  private list :Array<TagAlize>;
  @Output() createTag = new EventEmitter();
  constructor(private service : ServiceService) { 
  }

  ngOnInit() {
    this.list = new Array<TagAlize>();
  }

  getTagAlize() {
    this.service.getTagAlize(this.newTag).then((result)=>{
      if(result){
        for (let index = 0; index < result.length; index++) {
          const element = result[index];
          let item: TagAlize = new TagAlize();
          item.Normalized = element.Normalized;
          item.Tag = element.Tag
          this.list.push(item);
        }
      }
    }).catch((erro)=>{ console.log(erro)});
    this.createTag.emit(this.list);
  }
}
