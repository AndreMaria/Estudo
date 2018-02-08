'use strict';

var data = {
    'válido': {
        Login: {
            email: 'andremaria1980@gmail.com',
            password: '1234qwer'
        }
    },
    'inválido': {
      Login: {
        email: 'andremaria1980@gmail.com',
        password: '123456'
      }
    }
};

module.exports = { get: data }
