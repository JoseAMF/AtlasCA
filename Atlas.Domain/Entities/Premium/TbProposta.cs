﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbProposta
    {
        public string NrProposta { get; set; }
        public string NmPagador { get; set; }
        public string NrCpf { get; set; }
        public DateTime? DtNascimento { get; set; }
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
        public DateTime? DtInicioViagem { get; set; }
        public DateTime? DtFimViagem { get; set; }
        public string CdUfOrigemViagem { get; set; }
        public string IdPaisDestinoViagem { get; set; }
        public string IdMotivoViagem { get; set; }
        public string NmContatoEmergencia { get; set; }
        public string NrTelefoneEmergenciaCelular { get; set; }
        public string NrTelefoneEmergenciaResidencial { get; set; }
        public string NrTelefoneEmergenciaComercial { get; set; }
        public string NrIdentificadorPagamento { get; set; }
        public string CdFormaPagamento { get; set; }
        public string CdBandeiraCartao { get; set; }
        public string QtdeParcelas { get; set; }
        public decimal? VlPago { get; set; }
        public string CdTpMovimento { get; set; }
        public decimal? VlCotacao { get; set; }
        public string NrCupom { get; set; }
        public string CdTpCupom { get; set; }
        public decimal? PeDescontoCupom { get; set; }
        public string DvBagagemEspecial { get; set; }
        public string DvCompraProtegida { get; set; }
        public decimal? VlPremio { get; set; }
        public string IdCanalVenda { get; set; }
        public string DvPossuiDps { get; set; }
        public DateTime? DtAssinaturaDps { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int? CdBandeira { get; set; }
        public string CdSexo { get; set; }
        public DateTime? DtCotacao { get; set; }
        public string BraspagTransactionId { get; set; }
        public int? Idpoliza { get; set; }
        public string Idbase { get; set; }
        public int? QtdeDiasViagem { get; set; }
        public string Canal1 { get; set; }
        public string Canal2 { get; set; }
        public string Usuario { get; set; }
        public string Agencia { get; set; }
        public bool? DvRegresso { get; set; }
        public DateTime? DtRegresso { get; set; }
        public string Comentario { get; set; }

        [NotMapped]
        public ICollection<TbPropostaSegurado> Passageiros { get; set; }
    }
}
