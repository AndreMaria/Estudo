import { Component, OnInit } from '@angular/core';
import { CondicoesProcedimentoService } from './condicoes-procedimento-service';


@Component({
  selector: 'app-faturamento',
  templateUrl: './faturamento.component.html',
  styleUrls: ['./faturamento.component.css']
})
export class FaturamentoComponent implements OnInit {

  private condicoesService: CondicoesProcedimentoService;
  constructor() {
    this.condicoesService = new CondicoesProcedimentoService();
  }

  ngOnInit() {
  }

  onLoadProcedimentos() {
    const valores = this.condicoesService.GetProcedimentoPorCodigo('10101012');
    console.log(valores);
  }
}
