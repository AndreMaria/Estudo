"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var express_1 = require("express");
var router = express_1.Router();
router.get('/', function (request, response) {
    var email = request.body.email;
    var senha = request.body.email;
    console.log("O Email:" + email + " e a Senha: " + senha);
    response.send('Got a POST request');
});
router.post('/validation', function (request, response) {
    var email = request.body.email;
    var senha = request.body.email;
    console.log("O Email:" + email + " e a Senha: " + senha);
    response.send('Got a POST request');
});
router.post('/new', function (request, response) {
    var email = request;
    var senha = request.body;
    console.log("O Email:" + request.body.email + " e a Senha: " + request.body.senha);
    response.send('Got a POST request');
});
exports.LoginController = router;
//# sourceMappingURL=loginController.js.map