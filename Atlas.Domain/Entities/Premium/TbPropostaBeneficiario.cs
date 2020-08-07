using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbPropostaBeneficiario
    {
        public int IdBeneficiario { get; set; }
        public string NrVoucher { get; set; }
        public string NmBeneficiario { get; set; }
        public DateTime DtNascimento { get; set; }
        public string NrCpf { get; set; }
        public string IdParentesco { get; set; }
        public decimal PeParticipacao { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
