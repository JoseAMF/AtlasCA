using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTipoAplicacionPromocion
    {
        public PrTipoAplicacionPromocion()
        {
            PrPromociones = new HashSet<PrPromociones>();
        }

        public int IdTipoAplicacionPromocion { get; set; }
        public string CodigoTipoAplicacionPromocion { get; set; }
        public string DescripcionTipoAplicacionPromocion { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PrPromociones> PrPromociones { get; set; }
    }
}
