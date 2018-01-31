"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var express_1 = require("express");
var LoginController = /** @class */ (function () {
    function LoginController(router) {
        if (router === void 0) { router = express_1.Router(); }
        this.router = router;
        this.router.get('/', function (req, res) {
            res.send('Hello,World!');
        });
    }
    LoginController.prototype.getRouters = function () {
        this.router;
    };
    return LoginController;
}());
exports.LoginController = LoginController;
