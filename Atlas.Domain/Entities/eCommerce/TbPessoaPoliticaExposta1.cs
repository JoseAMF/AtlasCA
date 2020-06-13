using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class TbPessoaPoliticaExposta1
    {
        public int IdPpe { get; set; }
        public int IdBeneficiarioPoliza { get; set; }
        public string DvPpe { get; set; }
        public int? IdParentescoPpe { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual PoBeneficiariosPoliza IdBeneficiarioPolizaNavigation { get; set; }
        public virtual TbParentescoPpe1 IdParentescoPpeNavigation { get; set; }
    }
}
