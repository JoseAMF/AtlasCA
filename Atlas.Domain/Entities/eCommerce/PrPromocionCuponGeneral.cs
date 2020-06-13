using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrPromocionCuponGeneral
    {
        public int IdPromocionCuponGeneral { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public string AgenciasIn { get; set; }
        public string AgenciasNotIn { get; set; }
        public string ProductosIn { get; set; }
        public string ProductosNotIn { get; set; }
        public string CodigoCupon { get; set; }
        public string Descripcion { get; set; }
        public double? Bonificacion { get; set; }
    }
}
