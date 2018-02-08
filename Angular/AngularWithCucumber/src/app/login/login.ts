export class Login {
  private id: number;
  private email: string;
  private password: string;

  get Id() {
    return this.id;
  }
  set Id(value: number) {
    this.id = value;
  }

  get Email() {
    return this.email;
  }
  set Email(value: string) {
    this.email = value;
  }

  get Password() {
    return this.password;
  }
  set Password(value: string) {
    this.password = value;
  }
}
