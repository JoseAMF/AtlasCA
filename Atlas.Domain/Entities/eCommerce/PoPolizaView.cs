using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoPolizaView
    {
        public int Idpoliza { get; set; }
        public string Nropoliza { get; set; }
        public DateTime Fecemision { get; set; }
        public string Agencia { get; set; }
        public int Idproducto { get; set; }
        public double? Imptotal { get; set; }
        public string Beneftit { get; set; }
        public string Medpago { get; set; }
        public DateTime Fecdesde { get; set; }
        public DateTime Fechasta { get; set; }
        public decimal Porcen { get; set; }
    }
}
