using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class VwMovimento
    {
        public int CdAgencia { get; set; }
        public string DscAgencia { get; set; }
        public string DscSegmento { get; set; }
        public string Sellerid { get; set; }
        public string NrCertificado { get; set; }
        public string NrVoucher { get; set; }
        public string CdProduto { get; set; }
        public string DscProduto { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public DateTime DtInicioViagem { get; set; }
        public DateTime DtFimViagem { get; set; }
        public DateTime? DtFimExtensao { get; set; }
        public string PaisOrigem { get; set; }
        public string PaisDestino { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string Sexo { get; set; }
        public decimal? ValorProduto { get; set; }
        public decimal? PerDesconto { get; set; }
        public decimal? ValorVoucher { get; set; }
        public decimal? ValorExtensao { get; set; }
        public decimal? PerComissao { get; set; }
        public decimal? ValorDolar { get; set; }
        public string Moeda { get; set; }
        public string FormaPagto { get; set; }
        public int? CdVendedor { get; set; }
        public string DscVendedor { get; set; }
        public string DscContatoEmergencia { get; set; }
        public string DscTelefoneContatoEmergencia { get; set; }
        public string DscEMailContatoEmergencia { get; set; }
        public string DscArquivoPdf { get; set; }
        public string DscFile { get; set; }
        public string Idbase { get; set; }
        public double? NrParcelas { get; set; }
        public int? CdPpe { get; set; }
        public string DscPpe { get; set; }
        public int? IdDesconto { get; set; }
        public string DscDesconto { get; set; }
    }
}
