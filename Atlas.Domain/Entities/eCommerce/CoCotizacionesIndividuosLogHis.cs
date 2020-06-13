using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoCotizacionesIndividuosLogHis
    {
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
    }
}
