using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfAdditionalCoverage
    {
        public WcfAdditionalCoverage()
        {
            WcfPoVoucherAdditionalCoverage = new HashSet<WcfPoVoucherAdditionalCoverage>();
            WcfProductAdditionalCoverage = new HashSet<WcfProductAdditionalCoverage>();
            WcfProductAdditionalCoveragePrice = new HashSet<WcfProductAdditionalCoveragePrice>();
        }

        public int IdAdicional { get; set; }
        public string Codigo { get; set; }
        public string Adicional { get; set; }
        public string Descripcion { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string AdicionalIngles { get; set; }

        public virtual ICollection<WcfPoVoucherAdditionalCoverage> WcfPoVoucherAdditionalCoverage { get; set; }
        public virtual ICollection<WcfProductAdditionalCoverage> WcfProductAdditionalCoverage { get; set; }
        public virtual ICollection<WcfProductAdditionalCoveragePrice> WcfProductAdditionalCoveragePrice { get; set; }
    }
}
