import * as express from 'express'
module.exports = function (app:express. {
  debugger;
  var user = app.controllers;
  app.get('/user', user.index);
  app.post('/user/login', user.validateLogin);
  app.post('/user/new', user.newUser);
  app.post('/user/list', user.users);
}
