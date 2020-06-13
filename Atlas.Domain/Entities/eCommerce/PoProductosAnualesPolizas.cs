using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoProductosAnualesPolizas
    {
        public int IdProductoAnual { get; set; }
        public int? IdProducto { get; set; }
        public int? IdPoliza { get; set; }
        public int? IdPersona { get; set; }
        public string Dni { get; set; }
        public int? TotalDias { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaInicioVigencia { get; set; }
        public string CreadoPor { get; set; }
    }
}
