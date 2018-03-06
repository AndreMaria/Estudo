'use strict';

const Page = require('../../pages');

class ProtocoloConsultaPage extends Page {

    constructor() {
        super();
    }

    status() {
      //return this.css(query);
      return this.buscar.by.css('as-consulta .contador-consulta').first();
    }

}

module.exports = new ProtocoloConsultaPage();
