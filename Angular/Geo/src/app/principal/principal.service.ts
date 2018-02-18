import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Principal } from './principal';

@Injectable()
export class PrincipalService {

  private url:string ="http://localhost:52987/api/principal";
  constructor(private http:Http) { }

  GetById(id:number): Promise<any> {
    return this.http.get(`${this.url}/id`)
    .toPromise().then((response: Response) => { 
      return response.json(); 
    }).catch((erro)=> { 
      console.log(`[Erro]:${erro}`);
    });
  }

  GetByText(texto:string): Promise<any> {
    return this.http.get(`${this.url}/texto`)
    .toPromise().then((response: Response) => { 
      return response.json(); 
    }).catch((erro)=> { 
      console.log(`[Erro]:${erro}`);
    });
  }

  Save(item: Principal){
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    debugger;
    this.http.post(`${this.url}`,item,options);
  }
}
