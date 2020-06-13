using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoFacturacion
    {
        public int IdFactura { get; set; }
        public int IdPoliza { get; set; }
        public string Usuario { get; set; }
        public double Importe { get; set; }
        public bool Procesado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FechaProcesamiento { get; set; }
    }
}
