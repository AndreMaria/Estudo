import { Injectable } from '@angular/core';
import { Http, Request, Response, RequestOptions , Headers} from '@angular/http';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class TagService {

  private url:string ="http://localhost:52987/api/Values";

  constructor(private http: Http) { }

  getTagAlize(texto: string) : Promise<any> {
    let headers = new Headers({
      'Content-Type':'application/json; charset=utf-8;' 
      ,'Accept':'*/*'
    });
    let options = new RequestOptions({ headers: headers });
    return this.http.get(`${this.url}/${texto}`).toPromise().then((response:Response) => {
      return response.json();
    }).catch((erro)=>{ console.log(`[Erro]:${erro}`)});
  }
}
