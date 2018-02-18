import { Injectable } from '@angular/core';
import { Http, Response, Request, RequestOptions, Headers , RequestMethod} from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Main } from './main';

@Injectable()
export class ServiceService {

  private url: string = 'http://localhost:56163/api'

  private headers: Headers;

  constructor(private http: Http) { 
  }

  getTagAlize(text: string): Promise<any> {
    return this.http.get(`${this.url}/Util?words=${text}`).toPromise().then((response: Response)=> {
      return response.json();
    }).catch((erro)=>{ console.log(`[Erro]:${erro}`)});
  }

  onSave(item: Main) {

    this.headers = new Headers();
    this.headers.append("Content-Type", 'application/json');

    let requestoptions = new RequestOptions({
        method: RequestMethod.Post,
        url: `${this.url}/main/save`,
        headers: this.headers,
        body: JSON.stringify(item)
    })

    return this.http.request(new Request(requestoptions)).subscribe(
      data => {
        alert('ok');
      },
      error => {
        console.log('[**************************]');
        console.log(JSON.stringify(error.json()));
      }
    );
  }
}
