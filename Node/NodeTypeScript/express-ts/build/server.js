"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var express = require("express");
var user_1 = require("./controllers/user");
var login_1 = require("./controllers/login");
var app = express();
var port = process.env.PORT || 3000;
console.log(app._router);
var login = new login_1.LoginController(app._router);
app.use('/login', login.getRouters);
app.use('/user', user_1.UserController);
app.listen(port, function () { console.log("Listening at http://localhost:" + port + "/"); });
