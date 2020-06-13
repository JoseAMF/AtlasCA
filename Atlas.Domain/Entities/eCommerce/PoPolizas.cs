using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoPolizas
    {
        public PoPolizas()
        {
            CoConsumosVentas = new HashSet<CoConsumosVentas>();
            PoBeneficiariosPoliza = new HashSet<PoBeneficiariosPoliza>();
            PoDetalleFormasPago = new HashSet<PoDetalleFormasPago>();
            PoHistoricoVoucher = new HashSet<PoHistoricoVoucher>();
            PrLogPromocionesAplicadas = new HashSet<PrLogPromocionesAplicadas>();
        }

        public int IdPoliza { get; set; }
        public string NumeroPoliza { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public int IdProducto { get; set; }
        public double? ImporteTotal { get; set; }
        public int? IdVendedor { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdAgencia { get; set; }
        public string ApellidoContactoEmergencia { get; set; }
        public string NombreContactoEmergencia { get; set; }
        public string TelefonoContactoEmergencia { get; set; }
        public string EMailContactoEmergencia { get; set; }
        public int? DiasProductoAnual { get; set; }
        public string CodigoCupon { get; set; }
        public string IdEnBroker { get; set; }
        public int? IdCanalDistribucion { get; set; }
        public int? IdSellerIdcanalesVentas { get; set; }
        public double? PorcentajeAdicionalAnticipo { get; set; }
        public double? ImporteAgencia { get; set; }
        public int? IdDestino { get; set; }
        public int? IdMotivoViaje { get; set; }
        public string Comentario { get; set; }
        public string TipoVoucher { get; set; }
        public int? IdParentVoucher { get; set; }
        public string SalesChannelType { get; set; }
        public string SalesChannelCode { get; set; }
        public string CodigoAreaContactoEmergencia { get; set; }
        public string CiudadOrigen { get; set; }
        public int? IdConsultor { get; set; }
        public int? CouponTypeId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? QtDiasMultiViagem { get; set; }

        public virtual PrProducto IdProductoNavigation { get; set; }
        public virtual CoSellerIdcanalesVentas IdSellerIdcanalesVentasNavigation { get; set; }
        public virtual CoVendedoresAgencias IdVendedorNavigation { get; set; }
        public virtual ICollection<CoConsumosVentas> CoConsumosVentas { get; set; }
        public virtual ICollection<PoBeneficiariosPoliza> PoBeneficiariosPoliza { get; set; }
        public virtual ICollection<PoDetalleFormasPago> PoDetalleFormasPago { get; set; }
        public virtual ICollection<PoHistoricoVoucher> PoHistoricoVoucher { get; set; }
        public virtual ICollection<PrLogPromocionesAplicadas> PrLogPromocionesAplicadas { get; set; }
    }
}
