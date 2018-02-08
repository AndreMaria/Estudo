export class Params {

  this.name: string ;
  this.DataType = null;
  this.Size = null;
  this.Value:any;
  this.TypePut = null;

  get Id () { return this.id; }

  get Senha () { return this.senha; }

  get Email () { return this.email; }

  set Id (value: number) { this.id = value; }

  set Senha (value: string) { this.senha = value; }

  set Email (value: string) { this.email = value; }

}