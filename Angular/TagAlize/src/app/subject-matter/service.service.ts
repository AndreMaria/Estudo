import { Injectable } from '@angular/core';
import { Http, Response, Request, ResponseOptions, Headers, RequestMethod, Jsonp} from '@angular/http';
import '../../../node_modules/rxjs/add/operator/toPromise';
import {Observable} from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';

import { Tag } from './tag/Tag.model';
import { SubjectMatterView } from '../subject-matter/subject-matter-view.model';

@Injectable()
export class ServiceService {

  private url = 'http://localhost:54017/api/';

  constructor(private http: Http) { }

  GetTagAlize(text: string): Promise<any>  {
    return this.http.get(`${this.url}Util/?text=${text}`).toPromise().then((response) => {
      return response.json();
    }).catch((error) => {
      console.log(`Error:${error}`);
    });
  }

  GetTagAlizeObservable(text: string): Observable<Tag[]> {
    return this.http.get(`${this.url}Util/?text=${text}`)
            .map( (result) => result.json())
            .catch(erro => Observable.throw(erro.message));
  }

  PostSubectMatter(items: SubjectMatterView) {

    const headers: Headers = new Headers();
    headers.append('Content-Type', 'application/json');

    const responseOptions = new ResponseOptions({
      headers: headers
    });

    return this.http.post(`${this.url}SubjectMatter`, JSON.stringify(items), new Request(responseOptions))
      .subscribe(
        (response) => { response.json(); },
        (erro) => { console.log(erro); }
    );
  }
}
