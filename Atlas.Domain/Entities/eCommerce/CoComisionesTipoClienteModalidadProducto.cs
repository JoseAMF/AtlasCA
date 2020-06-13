using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoComisionesTipoClienteModalidadProducto
    {
        public int IdComisionModalidadProducto { get; set; }
        public int IdTipoRelacionClienteProducto { get; set; }
        public DateTime FechaVigencia { get; set; }
        public double Comision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoRelacionTipoClienteModalidadProducto IdTipoRelacionClienteProductoNavigation { get; set; }
    }
}
