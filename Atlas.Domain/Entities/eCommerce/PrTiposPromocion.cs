using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTiposPromocion
    {
        public PrTiposPromocion()
        {
            CoCotizacionesIndividuosLog = new HashSet<CoCotizacionesIndividuosLog>();
            PrLogPromocionesAplicadas = new HashSet<PrLogPromocionesAplicadas>();
            PrPromocionComboEtario = new HashSet<PrPromocionComboEtario>();
            PrPromocionCombos = new HashSet<PrPromocionCombos>();
            PrPromocionCupones = new HashSet<PrPromocionCupones>();
            PrPromocionDescuentoIndividual = new HashSet<PrPromocionDescuentoIndividual>();
            PrPromocionGrupoFamiliar = new HashSet<PrPromocionGrupoFamiliar>();
            PrPromocionPaisDestino = new HashSet<PrPromocionPaisDestino>();
            PrPromocionProducto = new HashSet<PrPromocionProducto>();
            PrPromocionRangosEtarios = new HashSet<PrPromocionRangosEtarios>();
        }

        public int IdTipoPromocion { get; set; }
        public int IdCompania { get; set; }
        public string CodigoTipoPromocion { get; set; }
        public string DescripcionTipoPromocion { get; set; }
        public string Sp { get; set; }
        public string TablaDetalle { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string DescripcionBase { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual ICollection<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<PrLogPromocionesAplicadas> PrLogPromocionesAplicadas { get; set; }
        public virtual ICollection<PrPromocionComboEtario> PrPromocionComboEtario { get; set; }
        public virtual ICollection<PrPromocionCombos> PrPromocionCombos { get; set; }
        public virtual ICollection<PrPromocionCupones> PrPromocionCupones { get; set; }
        public virtual ICollection<PrPromocionDescuentoIndividual> PrPromocionDescuentoIndividual { get; set; }
        public virtual ICollection<PrPromocionGrupoFamiliar> PrPromocionGrupoFamiliar { get; set; }
        public virtual ICollection<PrPromocionPaisDestino> PrPromocionPaisDestino { get; set; }
        public virtual ICollection<PrPromocionProducto> PrPromocionProducto { get; set; }
        public virtual ICollection<PrPromocionRangosEtarios> PrPromocionRangosEtarios { get; set; }
    }
}
