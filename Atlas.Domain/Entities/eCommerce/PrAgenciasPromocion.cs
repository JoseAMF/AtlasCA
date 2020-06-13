using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrAgenciasPromocion
    {
        public int IdAgenciaPromocion { get; set; }
        public int IdAgencia { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int IdTipoObjetivoComision { get; set; }
        public int CantidadObjetivo { get; set; }
        public string MarcaExclusionBonificaciones { get; set; }
        public double Comision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual PrTiposObjetivosAgencias IdTipoObjetivoComisionNavigation { get; set; }
    }
}
