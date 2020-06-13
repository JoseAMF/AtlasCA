using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrSubCobertura
    {
        public int IdSubCobertura { get; set; }
        public string SubCobertura { get; set; }
        public int IdServicio { get; set; }
        public int Orden { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
    }
}
