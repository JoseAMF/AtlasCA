using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTipoInicioCobertura
    {
        public int IdTipoInicioCobertura { get; set; }
        public string TipoInicioCobertura { get; set; }
        public string DescripcionTipoInicioCobertura { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
