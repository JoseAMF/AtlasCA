using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrCanalesPublicacionCupones
    {
        public PrCanalesPublicacionCupones()
        {
            PrPromocionCupones = new HashSet<PrPromocionCupones>();
        }

        public int IdCanalPublicacionCupon { get; set; }
        public string CodigoCanalPublicacion { get; set; }
        public string DenominacionCanalPublicacion { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PrPromocionCupones> PrPromocionCupones { get; set; }
    }
}
