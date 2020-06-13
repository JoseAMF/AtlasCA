using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoSellerIdcanalesVentas
    {
        public CoSellerIdcanalesVentas()
        {
            PoPolizas = new HashSet<PoPolizas>();
            PrSellerIdhabilitadosPromocion = new HashSet<PrSellerIdhabilitadosPromocion>();
        }

        public int IdSellerIdcanalesVentas { get; set; }
        public int IdAgencia { get; set; }
        public int IdCanalComercial { get; set; }
        public int IdCanalDistribucion { get; set; }
        public int IdTipoCanalVenta { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string SellerId { get; set; }
        public string Descripcion { get; set; }
        public string HeaderHtml { get; set; }
        public string Link { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? UserId { get; set; }
        public string Email { get; set; }
        public string FooterHtml { get; set; }
        public bool? TieneAsociados { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual CoCanalComercial IdCanalComercialNavigation { get; set; }
        public virtual CoCanalDistribucion IdCanalDistribucionNavigation { get; set; }
        public virtual CoTipoCanalVenta IdTipoCanalVentaNavigation { get; set; }
        public virtual ICollection<PoPolizas> PoPolizas { get; set; }
        public virtual ICollection<PrSellerIdhabilitadosPromocion> PrSellerIdhabilitadosPromocion { get; set; }
    }
}
