using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoServiciosImport
    {
        public string IdProducto { get; set; }
        public string IdServicio { get; set; }
        public string DenominacionProducto { get; set; }
        public string DescripcionServicio { get; set; }
        public string CodigoProducto { get; set; }
        public string FechaInicioVigencia { get; set; }
        public string IdUnidadMedida { get; set; }
        public string CodigoMoneda { get; set; }
        public string Tope { get; set; }
    }
}
