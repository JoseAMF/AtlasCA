using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoDetallesVenta
    {
        public CoDetallesVenta()
        {
            CoConsumosVentas = new HashSet<CoConsumosVentas>();
        }

        public int IdDetallesVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int CantidadDias { get; set; }
        public int IdMoneda { get; set; }
        public double PrecioVenta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdgrupoFamiliarIndividuo { get; set; }

        public virtual BsMonedas IdMonedaNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
        public virtual CoVentas IdVentaNavigation { get; set; }
        public virtual ICollection<CoConsumosVentas> CoConsumosVentas { get; set; }
    }
}
