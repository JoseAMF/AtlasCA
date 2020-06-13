using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class LpDocumentosPago
    {
        public LpDocumentosPago()
        {
            LpDetalleDocumentos = new HashSet<LpDetalleDocumentos>();
        }

        public int IdDocumentoPago { get; set; }
        public int IdCaso { get; set; }
        public int IdTipoProveedor { get; set; }
        public int? IdBeneficiarioPoliza { get; set; }
        public int? IdSocioOmint { get; set; }
        public int? IdCorresponsal { get; set; }
        public int? IdPrestadorExterior { get; set; }
        public string Cbu { get; set; }
        public string NumeroDocumento { get; set; }
        public string RazonSocialProveedor { get; set; }
        public string DomicilioProveedor { get; set; }
        public string NumeroDocumentoExterior { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public int IdRelacionProveedorFormaPago { get; set; }
        public string DomicilioDePago { get; set; }
        public int IdMonedaLiquidacion { get; set; }
        public double ImporteLiquidacion { get; set; }
        public int IdMonedaPago { get; set; }
        public double TipoCambio { get; set; }
        public double ImporteApagar { get; set; }
        public string ObservacionDocumento { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdPersonaFisica { get; set; }
        public int? IdPersonaJuridica { get; set; }
        public string Factura { get; set; }
        public int? IdFormaDePago { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string Cuil { get; set; }

        public virtual PoBeneficiariosPoliza IdBeneficiarioPolizaNavigation { get; set; }
        public virtual MiCasos IdCasoNavigation { get; set; }
        public virtual MiCorresponsales IdCorresponsalNavigation { get; set; }
        public virtual BsMonedas IdMonedaLiquidacionNavigation { get; set; }
        public virtual BsMonedas IdMonedaPagoNavigation { get; set; }
        public virtual ICollection<LpDetalleDocumentos> LpDetalleDocumentos { get; set; }
    }
}
