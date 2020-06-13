using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTiposObjetivosAgencias
    {
        public PrTiposObjetivosAgencias()
        {
            PrAgenciasPromocion = new HashSet<PrAgenciasPromocion>();
        }

        public int IdTipoObjetivoComision { get; set; }
        public int IdCompania { get; set; }
        public string CodigoTipoObjetivoComision { get; set; }
        public string DenominacionTipoObjetivoComision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual ICollection<PrAgenciasPromocion> PrAgenciasPromocion { get; set; }
    }
}
