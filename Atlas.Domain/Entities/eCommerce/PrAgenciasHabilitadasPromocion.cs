using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrAgenciasHabilitadasPromocion
    {
        public int IdAgenciaHabilitadaPromocion { get; set; }
        public int IdAgencia { get; set; }
        public int IdPromocion { get; set; }
        public DateTime FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual PrPromociones IdPromocionNavigation { get; set; }
    }
}
