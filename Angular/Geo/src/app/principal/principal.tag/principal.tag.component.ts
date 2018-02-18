import { Component, OnInit, Input } from '@angular/core';

import { Tag } from '../../tag/tag';
import { Label } from '../../label/label';
import { TagService } from '../../tag/tag.service';
import { StandardTags } from '../../tag/StandardTags';
import { StandardNormalized } from '../../tag/StandardNormalized';
import { Standard } from '../../tag/Standard';

@Component({
  selector: 'app-principal-tag',
  templateUrl: './principal.tag.component.html',
  styleUrls: ['./principal.tag.component.css'],
  providers: [TagService]
})
export class PrincipalTagComponent implements OnInit {

  private tag: Tag
  private listTag: Array<Tag>;
  private tagtexto: string;

  @Input() label : Label

  constructor(private service: TagService) { 
    this.tag = new Tag();
    this.listTag = new Array<Tag>();
  }

  ngOnInit() {
    if(this.label){
      this.service.getTagAlize(this.label.Texto).then((response)=>{ console.log(response); }).catch((erro)=> { console.log(`[Erro]:${erro}`)});
    } 
  }

  onTagAlize(event) {
    console.log('Tentou pesquisar');
    this.service.getTagAlize(this.tagtexto).then((response)=>{ console.log(response); }).catch((erro)=> { console.log(`[Erro]:${erro}`)});
  }

}
