using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbPropostaSegurado
    {
        public string NrVoucher { get; set; }
        public string NrProposta { get; set; }
        public string NrApolice { get; set; }
        public string NmSegurado { get; set; }
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
        public string DvPpe { get; set; }
        public string IdParentescoPpe { get; set; }
        public string CdProduto { get; set; }
        public decimal? VlPremioBruto { get; set; }
        public decimal? VlPremioLiquido { get; set; }
        public DateTime? DhInicioExtensao { get; set; }
        public DateTime? DhTerminoExtensao { get; set; }
        public decimal? VlExtensao { get; set; }
        public DateTime? DhCancelamento { get; set; }
        public DateTime? DhRetornoApolice { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
        public string CdSexo { get; set; }
        public string IdPaisDestinoViagem { get; set; }
        public string DsPaisDestinoViagem { get; set; }
        public int? IdAgencia { get; set; }
        public int? IdVendedor { get; set; }
        public string DsProduto { get; set; }
        public string DsFile { get; set; }
        public string DsPathArquivoPdf { get; set; }
        public int? NrIdadeInicial { get; set; }
        public int? NrIdadeFinal { get; set; }
        public string DvBagagemEspecial { get; set; }
        public string DvCompraProtegida { get; set; }
        public string CpfCnpjAgencia { get; set; }
        public string CpfCnpjVendedor { get; set; }
        public string DvCancelamento { get; set; }
        [NotMapped]
        public Boolean IntegradoI4Pro { get; set; }
        [NotMapped]
        public Boolean IntegradoCancelamento { get; set; }
    }
}
