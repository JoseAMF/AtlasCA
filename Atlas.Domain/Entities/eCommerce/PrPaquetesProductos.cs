using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrPaquetesProductos
    {
        public int IdPaquetesProductos { get; set; }
        public int IdProducto { get; set; }
        public int CantidadDias { get; set; }
        public int IdMoneda { get; set; }
        public double Importe { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsMonedas IdMonedaNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
    }
}
