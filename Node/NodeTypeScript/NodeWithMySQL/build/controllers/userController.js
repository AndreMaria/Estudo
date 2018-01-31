"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var UserController = /** @class */ (function () {
    function UserController() {
    }
    UserController.prototype.index = function (req, res) {
        res.render('index', { title: 'Express' });
    };
    return UserController;
}());
exports.UserController = UserController;
