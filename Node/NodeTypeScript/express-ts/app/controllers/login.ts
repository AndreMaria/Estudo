import { Router, Request, Response } from 'express'

export class LoginController {

  constructor(private router:Router = Router()){
    this.router.get('/',(req:Request,res:Response) => {
      res.send('Hello,World!');
    })
  }

  public getRouters(){
    this.router;
  }
}
