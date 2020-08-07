using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class BkpTbBeneficiario
    {
        public int IdBeneficiario { get; set; }
        public string IdApolicePremium { get; set; }
        public string DsNome { get; set; }
        public string DsSobrenome { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string CdSexo { get; set; }
        public string CdPais { get; set; }
        public string NrDocumento { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string CdIdioma { get; set; }
        public int? IdBeneplano { get; set; }
        public string CdLinhaProduto { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
