import { GuiaModelMock  } from './GuiaModelMock';
import { QuantidadeGuiaMock } from './QuantidadeGuiaMock';
import { ResultGuia } from './ResultGuia';
import { guiaSadtAut30EmDig } from './mock';

export class CondicoesGuiasService {

  private guias: Array<GuiaModelMock>;
  private quantidade: Array<QuantidadeGuiaMock>;

  constructor() {
    this.guias = guiaSadtAut30EmDig.guias.map(guia => new GuiaModelMock(guia));
    this.quantidade = new Array<QuantidadeGuiaMock>();
  }

  public GetQuantidade(req, res) {
    const list = ['NAO_DIGITADO', 'DIGITADO', 'ENVIADO'];
    for (let index = 0; index < list.length; index++) {
      req.query.situacao = list[index];
      const guias = this.GetGuiasTipoInclusao(req, res) ;
      let count = 0;
      guias.forEach( g => { count = count + 1; });
      this.quantidade.push(new QuantidadeGuiaMock(list[index], count));
    }
    return this.quantidade;
  }

  public GetResultGuia(req, res): ResultGuia {
    const resultGuia: ResultGuia = new ResultGuia();
    resultGuia.guias = this.GetGuias(req, res);
    if (resultGuia.guias) {
      resultGuia.totalCount = null != resultGuia.guias ? resultGuia.guias.length : 0;
      let valor = 0;
      resultGuia.guias.forEach( x => { valor =  valor + x.valor; } );
      resultGuia.valorTotal = valor;
    }
    return resultGuia;
  }

  private GetGuias(req, res): Array<GuiaModelMock> {
    const guias = this.GetGuiasTipoInclusao(req, res);
    if (req.query.valorDe && req.query.valorAte) {
      console.log(`GetGuias => com valor:`);
      return guias.filter(g =>
        g.valor >= req.query.valorDe
        && g.valor <= req.query.valorAte
        && g.dataConfirmacao >= req.query.dataDe
        && g.dataConfirmacao <= req.query.dataAte);

    } else {
      console.log(`GetGuias => sem valor:${guias.length}`);
      return guias.filter(g =>
        g.dataConfirmacao >= req.query.dataDe
        && g.dataConfirmacao <= req.query.dataAte);
    }
  }

  private GetGuiasTipoInclusao(req, res) {
    const guias = this.GetGuiasPorSituacao(req, res);
    if (req.query.guiaAutomatica) {
      if (req.query.guiaAutomatica === 'true' ) {
        console.log(`'GetGuiasTipoInclusao => Digitada Automaticamente'`);
        return guias.filter( g => g.tipoInclusao === 'Digitada Automaticamente');
      } else {
        console.log(`'GetGuiasTipoInclusao => Digitada'`);
        return guias.filter( g => g.tipoInclusao === 'Digitada');
      }
    } else {
      return guias;
    }
  }

  private GetGuiasPorSituacao(req, res) {
    console.log(`GetGuiasPorSituacao:req.query.situacao:${req.query.situacao}`);
    return this.GetGuiasPorTipo(req, res).filter( g => g.situacao === req.query.situacao);
  }

  private GetGuiasPorTipo(req, res) {
    console.log(`GetGuiasPorTipo:req.query.tipoGuia:${req.query.tipoGuia}`);
    return this.guias.filter(g => g.tipoGuia === req.query.tipoGuia);
  }
}
