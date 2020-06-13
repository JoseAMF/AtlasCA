using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrRelacionProductoModalidad
    {
        public int IdRelacionProductoModalidad { get; set; }
        public int IdProducto { get; set; }
        public int IdModalidadProducto { get; set; }
        public int CantidadDiasReferencia { get; set; }
        public int IdMoneda { get; set; }
        public double PrecioReferencial { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModPor { get; set; }

        public virtual PrModalidadProducto IdModalidadProductoNavigation { get; set; }
        public virtual BsMonedas IdMonedaNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
    }
}
