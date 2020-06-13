using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class VwProductoPrecio
    {
        public int? IdAgencia { get; set; }
        public int IdProductoPrecio { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? Dias { get; set; }
        public int? EdadDesde { get; set; }
        public int? EdadHasta { get; set; }
        public int IdMoneda { get; set; }
        public string CodigoMoneda { get; set; }
        public double Importe { get; set; }
    }
}
