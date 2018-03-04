import { Injectable } from '@angular/core';
import { Http, Response, Request, ResponseOptions, Headers, RequestMethod, Jsonp} from '@angular/http';
import '../../../node_modules/rxjs/add/operator/toPromise';

import { SubjectMatterView } from '../subject-matter/subject-matter-view.model';

@Injectable()
export class ServiceService {

  private url:string = 'http://localhost:57009/api/';

  constructor(private http: Http) { }

  GetTagAlize(text:string): Promise<any>  {
    return this.http.get(`${this.url}Util/?text=${text}`).toPromise().then((response)=> {
      return response.json()
    }).catch((error)=> {
      console.log(`Error:${error}`);
    });
  }

  PostSubectMatter(items: SubjectMatterView) {

    let headers: Headers = new Headers();
    headers.append('Content-Type', 'application/json');

    let response = new ResponseOptions({
      headers: headers
    });

    return this.http.post(`${this.url}SubjectMatter`,JSON.stringify(items), new Request(response))
      .subscribe(
        (response)=> { response.json()}, 
        (erro)=> { console.log(erro);}
    );
  }
}
