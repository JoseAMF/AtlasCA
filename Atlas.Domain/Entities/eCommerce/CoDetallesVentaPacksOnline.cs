using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoDetallesVentaPacksOnline
    {
        public int IdDetallesVentaPackOnline { get; set; }
        public int IdVentaPackOnline { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int CantidadDias { get; set; }
        public int IdMoneda { get; set; }
        public double PrecioVenta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public int IdPaisDestino { get; set; }

        public virtual BsMonedas IdMonedaNavigation { get; set; }
        public virtual BsPaises IdPaisDestinoNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
        public virtual CoVentaPacksOnline IdVentaPackOnlineNavigation { get; set; }
    }
}
