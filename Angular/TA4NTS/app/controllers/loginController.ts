import { Router, Request, Response} from 'express';

const router: Router = Router();

router.get('/', (request: Request, response: Response ) => {
  const email = request.body.email;
  const senha = request.body.email;
  console.log(`O Email:${email} e a Senha: ${senha}`);
  response.send('Got a POST request');
});

router.post('/validation', (request: Request, response: Response ) => {
  const email = request.body.email;
  const senha = request.body.email;
  console.log(`O Email:${email} e a Senha: ${senha}`);
  response.send('Got a POST request');
});

router.post('/new', (request: Request, response: Response ) => {
  const email = request;
  const senha = request.body;
  console.log(`O Email:${request.body.email} e a Senha: ${request.body.senha}`);
  response.send('Got a POST request');
});

export const LoginController: Router = router;
