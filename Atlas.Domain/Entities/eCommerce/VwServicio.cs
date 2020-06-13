using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class VwServicio
    {
        public int IdProductoServicio { get; set; }
        public int IdProducto { get; set; }
        public int IdServicio { get; set; }
        public string CodigoProducto { get; set; }
        public string DenominacionProducto { get; set; }
        public string DescripcionServicio { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public double? Tope { get; set; }
        public string Detalle { get; set; }
        public int? IdUnidadMedida { get; set; }
        public int? IdMoneda { get; set; }
        public string CodigoMoneda { get; set; }
    }
}
