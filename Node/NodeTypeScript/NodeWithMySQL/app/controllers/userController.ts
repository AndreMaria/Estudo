import {Request, Response} from 'express';
export class UserController {

  public index(req:Request, res:Response) {
    res.render('index', { title: 'Express' });
  }
}

