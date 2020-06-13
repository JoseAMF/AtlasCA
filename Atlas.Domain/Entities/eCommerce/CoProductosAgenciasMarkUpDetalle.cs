using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoProductosAgenciasMarkUpDetalle
    {
        public int IdDetallePam { get; set; }
        public int? IdProductoAgenciaMarkUp { get; set; }
        public DateTime? FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public double? MarkUp { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string CreadoPor { get; set; }
    }
}
