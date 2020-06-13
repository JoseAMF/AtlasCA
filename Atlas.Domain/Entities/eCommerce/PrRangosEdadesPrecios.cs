using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrRangosEdadesPrecios
    {
        public PrRangosEdadesPrecios()
        {
            PrPromocionGrupoFamiliar = new HashSet<PrPromocionGrupoFamiliar>();
            PrRelacionMultiproducto = new HashSet<PrRelacionMultiproducto>();
        }

        public int IdRangoEtareo { get; set; }
        public int? IdCompania { get; set; }
        public int? EdadDesde { get; set; }
        public int? EdadHasta { get; set; }
        public DateTime? InicioVigencia { get; set; }
        public DateTime? FinVigencia { get; set; }
        public int? IdGrupoRangosEdadesPrecios { get; set; }

        public virtual ICollection<PrPromocionGrupoFamiliar> PrPromocionGrupoFamiliar { get; set; }
        public virtual ICollection<PrRelacionMultiproducto> PrRelacionMultiproducto { get; set; }
    }
}
