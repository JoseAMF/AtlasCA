using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsParametros
    {
        public int IdParametros { get; set; }
        public string NombreParametro { get; set; }
        public string ValorParametro { get; set; }
        public string DescripcionParametro { get; set; }
        public int? IdCompania { get; set; }
    }
}
