using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class VwAgente
    {
        public int CdAgencia { get; set; }
        public string DscAgencia { get; set; }
        public decimal? PerComissao { get; set; }
        public string DscSegmento { get; set; }
        public string IdAgencia { get; set; }
        public string DscEndereco { get; set; }
        public string DscNumero { get; set; }
        public string DscComplemento { get; set; }
        public string DscBairro { get; set; }
        public string DscCep { get; set; }
        public string DscMail { get; set; }
        public string DscTelefone { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtBaixa { get; set; }
        public string DscExecutivoresponsavel { get; set; }
        public string Idbase { get; set; }
    }
}
