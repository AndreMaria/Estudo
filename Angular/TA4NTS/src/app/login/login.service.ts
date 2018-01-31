import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Login } from './login';

@Injectable()
export class LoginService {

  constructor(private http: Http) { }

  getLogin(login: Login) {
    return this.http.post('http://localhost:3000/login/validation', login)
    .toPromise()
    .then((response: Response) => {
      console.log(`Response:${response.json()}`);
      return response.json();
    })
    .catch((erro) => {
      console.log(erro);
    });
  }

  InsertLogin(login: Login) {
    return this.http.post('http://localhost:3000/login/new', login)
    .toPromise()
    .then((response: Response) => {
      console.log(`Response:${response.json()}`);
      response.json();
    })
    .catch((erro) => {
      console.log(erro);
    });
  }
}
