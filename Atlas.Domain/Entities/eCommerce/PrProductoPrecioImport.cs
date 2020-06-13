using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoPrecioImport
    {
        public string IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string FechaDesde { get; set; }
        public string Dias { get; set; }
        public string EdadDesde { get; set; }
        public string EdadHasta { get; set; }
        public string CodigoMoneda { get; set; }
        public string Importe { get; set; }
        public string IdProductoAdicional { get; set; }
        public string IdAgencia { get; set; }
    }
}
