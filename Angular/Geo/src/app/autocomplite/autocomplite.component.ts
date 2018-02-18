import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Principal } from '../principal/principal';
import { PrincipalService } from '../principal/principal.service';
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-autocomplite',
  templateUrl: './autocomplite.component.html',
  styleUrls: ['./autocomplite.component.css'],
  providers: [PrincipalService]
})
export class AutocompliteComponent implements OnInit {

  @Output() public onSelected = new EventEmitter<Principal>();
  public list:Array<Principal>
  public query: string = '';
  constructor(private service: PrincipalService) { 
    this.list = new Array<Principal>();
  }

  ngOnInit() {
  }

  onKey(event:any) {
    this.query = event.target.value;
    if (this.query.length > 2) {
      let result = this.service.GetByText(this.query);
      result.then((items) => {
        for( let i = 0; i < items.length; i++ ) {
          const element = items[i];
          const item:Principal = new Principal();
          item.Id = element.Id;
          item.Texto = element.Texto;
          this.list.push(item);
        }
      })
    }
  }

  onClick(texto:string){
    let item: Principal;
    this.onSelected.emit(item)
  }
}
