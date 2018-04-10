export class Model {
  constructor(objeto?) {
    Object.assign(this, objeto);
  }
}

export class GuiaModelMock extends Model {
    public numeroPedido: string;
    public dataConfirmacao: Date;
    public codigoGuia: string;
    public numeroGuia: string;
    public numeroGuiaPrestador: string;
    public lote: Array<any>;
    public codigoBeneficiario: string;
    public beneficiario: string;
    public tipoGuia: string;
    public situacao: string;
    public valor: number;
    public codigoUsuarioInclusao: string;
    public codigoUsuarioAlteracao: string;
    public nomeUsuario: string;
    public tipoInclusao: string;
    public possuiGlosa: Boolean;
    public possuiCancelamento: Boolean;
    public tipoGlosa: string;
}
