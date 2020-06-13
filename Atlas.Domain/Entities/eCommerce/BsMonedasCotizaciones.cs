using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsMonedasCotizaciones
    {
        public int IdMonedaCotizacion { get; set; }
        public int IdMoneda { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public double? Importe { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsMonedas IdMonedaNavigation { get; set; }
    }
}
