using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrGruposAfinidad
    {
        public PrGruposAfinidad()
        {
            PrProductoPrecio = new HashSet<PrProductoPrecio>();
            PrPromocionCupones = new HashSet<PrPromocionCupones>();
        }

        public int IdGrupoAfinidad { get; set; }
        public string CodigoGrupoAfinidad { get; set; }
        public string DescripcionGrupoAfinidad { get; set; }
        public string ObservacionGrupoAfinidad { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int IdCompania { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual ICollection<PrProductoPrecio> PrProductoPrecio { get; set; }
        public virtual ICollection<PrPromocionCupones> PrPromocionCupones { get; set; }
    }
}
