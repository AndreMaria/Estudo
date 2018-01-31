import { Router, Request, Response, Application } from 'express'
import { LoginController } from './../controllers/login';

export class UserRouter {
  private router:Router = Router();
  private login: LoginController = new LoginController(this.router)
  constructor(private app: Application){
    this.app.use("/login",this.login.getRouters);
  }
}
