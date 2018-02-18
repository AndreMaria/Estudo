import { Component, OnInit, Input } from '@angular/core';

import { ServiceService } from '../service.service';
import { TagAlize } from '../TagAlize'; 
import { Label } from '../label/label';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css'],
  providers: [ServiceService]
})
export class GridComponent implements OnInit {

  @Input() labelValue : Label;
  private list :Array<TagAlize>;
  constructor(private service : ServiceService) { }

  ngOnInit() {
    this.list = new Array<TagAlize>();
  }

  getTagAlize() {
    this.service.getTagAlize(this.labelValue.Category + this.labelValue.Text).then((result)=>{
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
  }

}
