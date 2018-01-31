export class Login {
  id: number;
  senha: string;
  email: string;

  get Id () { return this.id; }

  get Senha () { return this.senha; }

  get Email () { return this.email; }

  set Id (value: number) { this.id = value; }

  set Senha (value: string) { this.senha = value; }

  set Email (value: string) { this.email = value; }
}
