using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoComisionesAgencias : ICloneable
    {
        public int IdComisionAgencia { get; set; }
        public int IdAgencia { get; set; }
        public DateTime FechaComision { get; set; }
        public decimal Comision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdPeriodicidadComision { get; set; }
        public int? Meta { get; set; }
        public int? IdUnidadMeta { get; set; }
        public int? IdTipoComision { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
    }
}
