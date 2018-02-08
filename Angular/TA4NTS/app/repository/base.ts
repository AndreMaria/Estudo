import * as MySql from 'mysql';
import { Router, Request, Response} from 'express';


export class Base {

  constructor(private mySql: MySql) {
  }

  private connection() {
    return this.mySql.createConnection({
      host:  'localhost',
      user: 'yourusername',
      password: 'yourpassword'
    });
  }

  private statusConnection() {
    this.connection().connect((erro) => {
      if (!erro) {
        console.log('Database is connected ... nn');
      } else {
        console.log('Error connecting database ... nn');
      }
    });
  }

  public execProcedureQuery(request: Request, response: Response, params: )
}

