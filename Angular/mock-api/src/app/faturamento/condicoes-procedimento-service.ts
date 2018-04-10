import { procedimentoGuia } from './procedimento-guias.data';

export class Model {

  constructor(objeto?) {
    Object.assign(this, objeto);
  }
}

export class Procedimento extends Model {
  public codigo: string;
  public descricao: string;
  public via: Via;
  public tecnica: Tecnica;
  public valorTotal: number;
  public despesa: Despesa;
  public unidadeMedida: UnidadeMedida;
}

export class Via {
  public codigo: string;
  public descricao: string;
}

export class Tecnica {
  public codigo: string;
  public descricao: string;
}

export class Despesa {
  public codigo: string;
  public descricao: string;
}

export class UnidadeMedida {
  public codigo: string;
  public descricao: string;
}

export class CondicoesProcedimentoService {

  private procedimentos: Array<Procedimento>;

  constructor() {
    this.procedimentos = procedimentoGuia.resultados.map(guia => new Procedimento(guia));
  }

  public GetProcedimentoPorCodigo(codigoGuia) {
    return this.procedimentos.filter( g => g.codigo === codigoGuia);
  }

}
