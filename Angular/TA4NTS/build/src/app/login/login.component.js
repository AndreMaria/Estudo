"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var login_1 = require("./login");
var login_service_1 = require("./login.service");
var LoginComponent = /** @class */ (function () {
    function LoginComponent(formBuilder, service) {
        this.formBuilder = formBuilder;
        this.service = service;
    }
    LoginComponent.prototype.ngOnInit = function () {
        this.validarForms();
    };
    LoginComponent.prototype.validarForms = function () {
        this.formLogin = this.formBuilder.group({
            email: ['', [forms_1.Validators.required]],
            senha: ['', [forms_1.Validators.required]]
        });
    };
    LoginComponent.prototype.isInvalid = function (field, validate) {
        var fieldControl = this.formLogin.controls[field];
        return (fieldControl.touched) && (this.formLogin.hasError(validate)
            || ((validate) ? (fieldControl.hasError(validate)) : fieldControl.invalid));
    };
    LoginComponent.prototype.metodoSend = function () {
        if (this.formLogin.valid) {
            var login = new login_1.Login();
            login.Email = this.email;
            login.Senha = this.senha;
            var response = this.service.getLogin(login);
        }
        else {
            this.mensagem = 'Form Invalido!';
        }
    };
    LoginComponent = __decorate([
        core_1.Component({
            selector: 'app-login',
            templateUrl: './login.component.html',
            styleUrls: ['./login.component.css'],
            providers: [login_service_1.LoginService]
        }),
        __metadata("design:paramtypes", [forms_1.FormBuilder, login_service_1.LoginService])
    ], LoginComponent);
    return LoginComponent;
}());
exports.LoginComponent = LoginComponent;
//# sourceMappingURL=login.component.js.map