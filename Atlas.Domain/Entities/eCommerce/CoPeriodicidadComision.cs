using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoPeriodicidadComision
    {
        public int IdPeriodicidadComision { get; set; }
        public string CodigoPeriodicidadComision { get; set; }
        public string DescripcionPeriodicidadComision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
