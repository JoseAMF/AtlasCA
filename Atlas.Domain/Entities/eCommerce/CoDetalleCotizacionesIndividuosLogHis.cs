using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoDetalleCotizacionesIndividuosLogHis
    {
        public int IdDetalleCotizacionesIndividuos { get; set; }
        public int IdCotizacionIndividuo { get; set; }
        public int? IdRangoEtario { get; set; }
        public int? CantidadPasajeros { get; set; }
        public int? IdMoneda { get; set; }
        public double? Importe { get; set; }
        public int? Edad { get; set; }
        public double? Bonificacion { get; set; }
        public double? ImporteFinal { get; set; }
        public DateTime? FecCreaReg { get; set; }
    }
}
