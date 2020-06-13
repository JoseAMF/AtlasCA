using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoFormasPago
    {
        public PoFormasPago()
        {
            CoClientesIndividuales = new HashSet<CoClientesIndividuales>();
            CoFormasPagoAgencias = new HashSet<CoFormasPagoAgencias>();
            CoVentasFormaPago = new HashSet<CoVentasFormaPago>();
            PeFormasPagoTipoCliente = new HashSet<PeFormasPagoTipoCliente>();
            PoDetalleFormasPago = new HashSet<PoDetalleFormasPago>();
            PrFormaPagoCuotaInteres = new HashSet<PrFormaPagoCuotaInteres>();
            PrFormasPagoProducto = new HashSet<PrFormasPagoProducto>();
        }

        public int IdFormaPago { get; set; }
        public string CodigoFormaPago { get; set; }
        public string DescripcionFormaPago { get; set; }
        public string TipoFormaPago { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string UrlPagoOnline { get; set; }
        public int? CantidadCuotas { get; set; }
        public int? IdTipoInteres { get; set; }
        public string CodigoPasarela { get; set; }
        public string ImagenUrl { get; set; }

        public virtual ICollection<CoClientesIndividuales> CoClientesIndividuales { get; set; }
        public virtual ICollection<CoFormasPagoAgencias> CoFormasPagoAgencias { get; set; }
        public virtual ICollection<CoVentasFormaPago> CoVentasFormaPago { get; set; }
        public virtual ICollection<PeFormasPagoTipoCliente> PeFormasPagoTipoCliente { get; set; }
        public virtual ICollection<PoDetalleFormasPago> PoDetalleFormasPago { get; set; }
        public virtual ICollection<PrFormaPagoCuotaInteres> PrFormaPagoCuotaInteres { get; set; }
        public virtual ICollection<PrFormasPagoProducto> PrFormasPagoProducto { get; set; }
    }
}
