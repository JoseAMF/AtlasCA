using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrRelacionMultiproducto
    {
        public int IdRelacionMultiproducto { get; set; }
        public int IdProductoPadre { get; set; }
        public int IdProductoHijo { get; set; }
        public int IdRangoEtareo { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? EdadDesde { get; set; }
        public int? EdadHasta { get; set; }

        public virtual PrProducto IdProductoHijoNavigation { get; set; }
        public virtual PrProducto IdProductoPadreNavigation { get; set; }
        public virtual PrRangosEdadesPrecios IdRangoEtareoNavigation { get; set; }
    }
}
