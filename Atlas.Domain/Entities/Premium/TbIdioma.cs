using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbIdioma
    {
        public TbIdioma()
        {
            TbBeneficiario = new HashSet<TbBeneficiario>();
        }

        public string CdIdioma { get; set; }
        public string DsIdioma { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual ICollection<TbBeneficiario> TbBeneficiario { get; set; }
    }
}
