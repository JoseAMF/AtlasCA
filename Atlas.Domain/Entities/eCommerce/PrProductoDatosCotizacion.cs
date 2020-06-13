using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoDatosCotizacion
    {
        public int IdProducto { get; set; }
        public int? IdOrigen { get; set; }
        public int? IdDestino { get; set; }
        public DateTime? DFechaDesde { get; set; }
        public DateTime? DFechaHasta { get; set; }
        public int? Cant0a18 { get; set; }
        public int? Cant19a25 { get; set; }
        public int? Cant26a69 { get; set; }
        public int? Cant70a85 { get; set; }
        public string Usuario { get; set; }
        public string NombrePagina { get; set; }
    }
}
