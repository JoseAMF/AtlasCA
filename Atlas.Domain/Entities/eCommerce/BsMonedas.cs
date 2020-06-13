using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsMonedas
    {
        public BsMonedas()
        {
            BsMonedasCotizaciones = new HashSet<BsMonedasCotizaciones>();
            CoDetalleCotizacionesIndividuosLog = new HashSet<CoDetalleCotizacionesIndividuosLog>();
            CoDetallesVenta = new HashSet<CoDetallesVenta>();
            CoDetallesVentaPacksOnline = new HashSet<CoDetallesVentaPacksOnline>();
            LpDocumentosPagoIdMonedaLiquidacionNavigation = new HashSet<LpDocumentosPago>();
            LpDocumentosPagoIdMonedaPagoNavigation = new HashSet<LpDocumentosPago>();
            PrPaquetesProductos = new HashSet<PrPaquetesProductos>();
            PrProducto = new HashSet<PrProducto>();
            PrProductoPrecio = new HashSet<PrProductoPrecio>();
            PrRelacionProductoModalidad = new HashSet<PrRelacionProductoModalidad>();
        }

        public int IdMoneda { get; set; }
        public string CodigoMoneda { get; set; }
        public string Moneda { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<BsMonedasCotizaciones> BsMonedasCotizaciones { get; set; }
        public virtual ICollection<CoDetalleCotizacionesIndividuosLog> CoDetalleCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<CoDetallesVenta> CoDetallesVenta { get; set; }
        public virtual ICollection<CoDetallesVentaPacksOnline> CoDetallesVentaPacksOnline { get; set; }
        public virtual ICollection<LpDocumentosPago> LpDocumentosPagoIdMonedaLiquidacionNavigation { get; set; }
        public virtual ICollection<LpDocumentosPago> LpDocumentosPagoIdMonedaPagoNavigation { get; set; }
        public virtual ICollection<PrPaquetesProductos> PrPaquetesProductos { get; set; }
        public virtual ICollection<PrProducto> PrProducto { get; set; }
        public virtual ICollection<PrProductoPrecio> PrProductoPrecio { get; set; }
        public virtual ICollection<PrRelacionProductoModalidad> PrRelacionProductoModalidad { get; set; }
    }
}
