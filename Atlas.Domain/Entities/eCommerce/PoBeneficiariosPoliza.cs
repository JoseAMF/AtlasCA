using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoBeneficiariosPoliza
    {
        public PoBeneficiariosPoliza()
        {
            LpDocumentosPago = new HashSet<LpDocumentosPago>();
            PrLogPromocionesDetalle = new HashSet<PrLogPromocionesDetalle>();
            TbPessoaPoliticaExposta1 = new HashSet<TbPessoaPoliticaExposta1>();
        }

        public int IdBeneficiarioPoliza { get; set; }
        public int IdPoliza { get; set; }
        public int IdPersona { get; set; }
        public bool MarcaTitular { get; set; }
        public int? IdParentesco { get; set; }
        public double? Importe { get; set; }
        public double? PorcentajeBonificado { get; set; }
        public double? TotalFacturado { get; set; }
        public int? IdPersonaBeneficiarioSeguro { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public DateTime? FecElimReg { get; set; }
        public string EliminadoPor { get; set; }
        public string HashVoucher { get; set; }
        public int? Secuencia { get; set; }
        public string Pdfvoucher { get; set; }
        public DateTime? FechaAceptacionCondiciones { get; set; }
        public int? Viaja { get; set; }
        public int? IdTipoDocumento { get; set; }
        public double? ImporteGrilla { get; set; }
        public double? ImporteConPromocion { get; set; }
        public double? MarkUp { get; set; }
        public double? ImporteConMarkUp { get; set; }
        public double? Interes { get; set; }
        public double? ImporteConInteres { get; set; }
        public double? PorcentajeBonificadoInicial { get; set; }
        public double? TotalFacturadoGrilla { get; set; }
        public int? IdProducto { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public DateTime? ExtensionFecha { get; set; }
        public DateTime? ExtensionVigenciaHasta { get; set; }
        public double? ExtensionValorCotizado { get; set; }
        public int? ExtensionIdpago { get; set; }
        public double? ExtensionValorPagado { get; set; }
        public int? IdPoextensionAutorizacion { get; set; }

        public virtual PoParentesco IdParentescoNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
        public virtual PoPolizas IdPolizaNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
        public virtual ICollection<LpDocumentosPago> LpDocumentosPago { get; set; }
        public virtual ICollection<PrLogPromocionesDetalle> PrLogPromocionesDetalle { get; set; }
        public virtual ICollection<TbPessoaPoliticaExposta1> TbPessoaPoliticaExposta1 { get; set; }
    }
}
