using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProducto
    {
        public PrProducto()
        {
            CoCotizacionesIndividuosLog = new HashSet<CoCotizacionesIndividuosLog>();
            CoDetallesVenta = new HashSet<CoDetallesVenta>();
            CoDetallesVentaPacksOnline = new HashSet<CoDetallesVentaPacksOnline>();
            CoNominasEmpresas = new HashSet<CoNominasEmpresas>();
            PoBeneficiariosPoliza = new HashSet<PoBeneficiariosPoliza>();
            PoPolizas = new HashSet<PoPolizas>();
            PrFormasPagoProducto = new HashSet<PrFormasPagoProducto>();
            PrPaquetesProductos = new HashSet<PrPaquetesProductos>();
            PrProductoPrecio = new HashSet<PrProductoPrecio>();
            PrProductoServicios = new HashSet<PrProductoServicios>();
            PrProductosHabilitadosPromocion = new HashSet<PrProductosHabilitadosPromocion>();
            PrPromocionProducto = new HashSet<PrPromocionProducto>();
            PrRelacionMultiproductoIdProductoHijoNavigation = new HashSet<PrRelacionMultiproducto>();
            PrRelacionMultiproductoIdProductoPadreNavigation = new HashSet<PrRelacionMultiproducto>();
            PrRelacionProductoModalidad = new HashSet<PrRelacionProductoModalidad>();
            PrVigenciaProducto = new HashSet<PrVigenciaProducto>();
            TbProduto = new HashSet<TbProduto>();
            WcfDestinyShowCase = new HashSet<WcfDestinyShowCase>();
            WcfProductAdditionalCoverage = new HashSet<WcfProductAdditionalCoverage>();
            WcfProductAdditionalCoveragePrice = new HashSet<WcfProductAdditionalCoveragePrice>();
            WcfProductShowCaseProduct = new HashSet<WcfProductShowCase>();
            WcfProductShowCaseRelatedProduct = new HashSet<WcfProductShowCase>();
            WcfSpecialAudiencesShowCase = new HashSet<WcfSpecialAudiencesShowCase>();
            WcfTopicShowCase = new HashSet<WcfTopicShowCase>();
        }

        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string DenominacionProducto { get; set; }
        public int MinimoDias { get; set; }
        public int MaximoDias { get; set; }
        public int EdadMaxima { get; set; }
        public string Leyenda { get; set; }
        public int IdTipoCobertura { get; set; }
        public string Linkproducto { get; set; }
        public int IdMoneda { get; set; }
        public decimal CoberturaMaxima { get; set; }
        public string ProductoAgencias { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdTipoProducto { get; set; }
        public int? IdMarca { get; set; }
        public int? IdTipoViaje { get; set; }
        public string CondicionesGenerales { get; set; }
        public string MarcaProductoBase { get; set; }
        public string PdfCondicionesGenerales { get; set; }
        public string LeyendaValidez { get; set; }
        public string LeyendaTratadoEuropa { get; set; }
        public string LeyendaValidezIngles { get; set; }
        public string LeyendaTratadoEuropaIngles { get; set; }
        public string LeyendaIngles { get; set; }
        public int? Orden { get; set; }
        public bool? MuestraIngles { get; set; }
        public int? IdGrupoRangosEdad { get; set; }
        public string CondicionesGenerales2 { get; set; }
        public string Restricciones { get; set; }
        public string Descripcion { get; set; }
        public string Rpt { get; set; }

        public virtual PrMarcasProductos IdMarcaNavigation { get; set; }
        public virtual BsMonedas IdMonedaNavigation { get; set; }
        public virtual PrTipoCobertura IdTipoCoberturaNavigation { get; set; }
        public virtual PrTipoViaje IdTipoViajeNavigation { get; set; }
        public virtual ICollection<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<CoDetallesVenta> CoDetallesVenta { get; set; }
        public virtual ICollection<CoDetallesVentaPacksOnline> CoDetallesVentaPacksOnline { get; set; }
        public virtual ICollection<CoNominasEmpresas> CoNominasEmpresas { get; set; }
        public virtual ICollection<PoBeneficiariosPoliza> PoBeneficiariosPoliza { get; set; }
        public virtual ICollection<PoPolizas> PoPolizas { get; set; }
        public virtual ICollection<PrFormasPagoProducto> PrFormasPagoProducto { get; set; }
        public virtual ICollection<PrPaquetesProductos> PrPaquetesProductos { get; set; }
        public virtual ICollection<PrProductoPrecio> PrProductoPrecio { get; set; }
        public virtual ICollection<PrProductoServicios> PrProductoServicios { get; set; }
        public virtual ICollection<PrProductosHabilitadosPromocion> PrProductosHabilitadosPromocion { get; set; }
        public virtual ICollection<PrPromocionProducto> PrPromocionProducto { get; set; }
        public virtual ICollection<PrRelacionMultiproducto> PrRelacionMultiproductoIdProductoHijoNavigation { get; set; }
        public virtual ICollection<PrRelacionMultiproducto> PrRelacionMultiproductoIdProductoPadreNavigation { get; set; }
        public virtual ICollection<PrRelacionProductoModalidad> PrRelacionProductoModalidad { get; set; }
        public virtual ICollection<PrVigenciaProducto> PrVigenciaProducto { get; set; }
        public virtual ICollection<TbProduto> TbProduto { get; set; }
        public virtual ICollection<WcfDestinyShowCase> WcfDestinyShowCase { get; set; }
        public virtual ICollection<WcfProductAdditionalCoverage> WcfProductAdditionalCoverage { get; set; }
        public virtual ICollection<WcfProductAdditionalCoveragePrice> WcfProductAdditionalCoveragePrice { get; set; }
        public virtual ICollection<WcfProductShowCase> WcfProductShowCaseProduct { get; set; }
        public virtual ICollection<WcfProductShowCase> WcfProductShowCaseRelatedProduct { get; set; }
        public virtual ICollection<WcfSpecialAudiencesShowCase> WcfSpecialAudiencesShowCase { get; set; }
        public virtual ICollection<WcfTopicShowCase> WcfTopicShowCase { get; set; }
    }
}
