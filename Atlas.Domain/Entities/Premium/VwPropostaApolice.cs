using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class VwPropostaApolice
    {
        public string NrPedido { get; set; }
        public string NmPagador { get; set; }
        public string NrCpfPagador { get; set; }
        public string CdSexoPagador { get; set; }
        public string DtNascimentoPagador { get; set; }
        public string DtCotacao { get; set; }
        public string DtInicioViagem { get; set; }
        public string DtFimViagem { get; set; }
        public string CdUfOrigemViagem { get; set; }
        public string IdPaisDestinoViagem { get; set; }
        public string IdMotivoViagem { get; set; }
        public string NrTelefoneCelularPagador { get; set; }
        public string NrTelefoneResidencialPagador { get; set; }
        public string NmContatoEmergencia { get; set; }
        public string NrTelefoneEmergenciaCelular { get; set; }
        public string NrTelefoneEmergenciaResidencial { get; set; }
        public string NrTelefoneEmergenciaComercial { get; set; }
        public string NrIdentificadorPagamento { get; set; }
        public string NrCobranca { get; set; }
        public string CdFormaPagamento { get; set; }
        public int? CdBandeira { get; set; }
        public string QtdeParcelas { get; set; }
        public decimal? VlPago { get; set; }
        public decimal? VlCotacao { get; set; }
        public string NrCupom { get; set; }
        public string CdTpCupom { get; set; }
        public decimal? PeDescontoCupom { get; set; }
        public string DvBagagemEspecial { get; set; }
        public string DvCompraProtegida { get; set; }
        public string DvCancelamento { get; set; }
        public decimal? VlPremio { get; set; }
        public int? IdCanalVenda { get; set; }
        public string DvPossuiDps { get; set; }
        public DateTime? DtAssinaturaDps { get; set; }
        public string NrProposta { get; set; }
        public string NrApolice { get; set; }
        public string NmSegurado { get; set; }
        public string NrCpfSegurado { get; set; }
        public string CdSexoSegurado { get; set; }
        public string DtNascimentoSegurado { get; set; }
        public string NmEndereco { get; set; }
        public string NrRuaEndereco { get; set; }
        public string NmComplemento { get; set; }
        public string NmCep { get; set; }
        public string NmUf { get; set; }
        public string NmBairro { get; set; }
        public string NmCidade { get; set; }
        public string NrTelefoneCelular { get; set; }
        public string NrTelefoneResidencial { get; set; }
        public string NrTelefoneComercial { get; set; }
        public string NmEmail { get; set; }
        public string DvPpe { get; set; }
        public string IdParentescoPpe { get; set; }
        public string CdProduto { get; set; }
        public decimal? VlPremioBruto { get; set; }
        public decimal? VlPremioLiquido { get; set; }
        public DateTime? DhRetornoApolice { get; set; }
        public int? IdPessoaCorretor { get; set; }
        public int? CdTpPapel { get; set; }
        public string PeParticipacaoCorretor { get; set; }
        public decimal? PeComissao { get; set; }
        public string DvCorretorPrincipal { get; set; }
        public string NmBeneficiario { get; set; }
        public string DtNascimento { get; set; }
        public string NrCpf { get; set; }
        public string IdParentesco { get; set; }
        public decimal? PeParticipacaoBeneficiario { get; set; }
        public string CdPergunta { get; set; }
        public string IdResposta { get; set; }
        public string NmComplementoResposta { get; set; }
        public string CdTpMovimento { get; set; }
        public string DsPatharquivopdf { get; set; }
        public string TpOperacao { get; set; }
        public int QtdeDiasViagem { get; set; }
        public string NmCanalVendas2 { get; set; }
        public string NmUsuario { get; set; }
        public string NmAgencia { get; set; }
        public bool? DvRegresso { get; set; }
        public DateTime? DtRegresso { get; set; }
        public string Comentario { get; set; }
    }
}
