using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeTiposCalle
    {
        public PeTiposCalle()
        {
            PeDomicilios = new HashSet<PeDomicilios>();
        }

        public int IdTipoCalle { get; set; }
        public int IdCompania { get; set; }
        public string CodigoTipoCalle { get; set; }
        public string DescripcionTipoCalle { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual ICollection<PeDomicilios> PeDomicilios { get; set; }
    }
}
