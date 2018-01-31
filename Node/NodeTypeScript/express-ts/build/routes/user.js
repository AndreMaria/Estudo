"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var express = require("express");
var User = /** @class */ (function () {
    function User(app) {
        if (app === void 0) { app = express(); }
        this.app = app;
        this.user = app._router;
        app.get('/user', this.user.index);
    }
    return User;
}());
exports.User = User;
