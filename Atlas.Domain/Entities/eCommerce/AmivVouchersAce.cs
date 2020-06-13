using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivVouchersAce
    {
        public string Sequencial { get; set; }
        public string TipoRegistro { get; set; }
        public string NomeDoAsegurado { get; set; }
        public string Cpf { get; set; }
        public string DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        public string Voucher { get; set; }
        public string DataEmissão { get; set; }
        public string DataCheckIn { get; set; }
        public string DataCheckOut { get; set; }
        public int? NºDiasViagem { get; set; }
        public string DataDoCancelamento { get; set; }
        public string Produto { get; set; }
        public string Plano { get; set; }
        public string NºSorte { get; set; }
        public int? IdAgencia { get; set; }
        public string RazonSocial { get; set; }
        public double? ValordoVoucher { get; set; }
    }
}
