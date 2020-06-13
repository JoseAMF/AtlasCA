using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoCotizacionesIndividuosLog
    {
        public CoCotizacionesIndividuosLog()
        {
            CoDetalleCotizacionesIndividuosLog = new HashSet<CoDetalleCotizacionesIndividuosLog>();
        }

        public int IdCotizacionIndividuo { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdPais { get; set; }
        public int? IdTipoViaje { get; set; }
        public int? IdTipoProducto { get; set; }
        public string MarcaDestinoEuropa { get; set; }
        public DateTime? FechaInicVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int? IdProducto { get; set; }
        public int? IdCuponDescuento { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string CreadoPor { get; set; }
        public double? ValorTotal { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int? IdAgencia { get; set; }
        public int? IdTipoPromocion { get; set; }
        public int? IdDetallePromocion { get; set; }
        public double? ValorGrilla { get; set; }
        public string Cupon { get; set; }
        public int? ProductTypeId { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual BsPaises IdPaisNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
        public virtual BsProvincias IdProvinciaNavigation { get; set; }
        public virtual PrTipoProducto IdTipoProductoNavigation { get; set; }
        public virtual PrTiposPromocion IdTipoPromocionNavigation { get; set; }
        public virtual PrTipoViaje IdTipoViajeNavigation { get; set; }
        public virtual ICollection<CoDetalleCotizacionesIndividuosLog> CoDetalleCotizacionesIndividuosLog { get; set; }
    }
}
