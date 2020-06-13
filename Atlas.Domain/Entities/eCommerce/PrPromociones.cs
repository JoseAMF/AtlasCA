using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrPromociones
    {
        public PrPromociones()
        {
            PrAgenciasHabilitadasPromocion = new HashSet<PrAgenciasHabilitadasPromocion>();
            PrLogPromocionesAplicadas = new HashSet<PrLogPromocionesAplicadas>();
            PrProductosHabilitadosPromocion = new HashSet<PrProductosHabilitadosPromocion>();
            PrPromocionComboEtario = new HashSet<PrPromocionComboEtario>();
            PrPromocionCombos = new HashSet<PrPromocionCombos>();
            PrPromocionCupones = new HashSet<PrPromocionCupones>();
            PrPromocionDescuentoIndividual = new HashSet<PrPromocionDescuentoIndividual>();
            PrPromocionGrupoFamiliar = new HashSet<PrPromocionGrupoFamiliar>();
            PrPromocionPaisDestino = new HashSet<PrPromocionPaisDestino>();
            PrPromocionProducto = new HashSet<PrPromocionProducto>();
            PrPromocionRangosEtarios = new HashSet<PrPromocionRangosEtarios>();
            PrSellerIdhabilitadosPromocion = new HashSet<PrSellerIdhabilitadosPromocion>();
        }

        public int IdPromocion { get; set; }
        public int IdCompania { get; set; }
        public int IdTipoAplicacionPromocion { get; set; }
        public string CodigoPromocion { get; set; }
        public string DescripcionPromocion { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int IdTipoProducto { get; set; }
        public string MarcaTodasAgencias { get; set; }
        public decimal? Multiplicador { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string MarcaTodosSellersId { get; set; }
        public DateTime? FechaLimiteInicioViaje { get; set; }
        public string MarcaTodosProductos { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual PrTipoAplicacionPromocion IdTipoAplicacionPromocionNavigation { get; set; }
        public virtual PrTipoProducto IdTipoProductoNavigation { get; set; }
        public virtual ICollection<PrAgenciasHabilitadasPromocion> PrAgenciasHabilitadasPromocion { get; set; }
        public virtual ICollection<PrLogPromocionesAplicadas> PrLogPromocionesAplicadas { get; set; }
        public virtual ICollection<PrProductosHabilitadosPromocion> PrProductosHabilitadosPromocion { get; set; }
        public virtual ICollection<PrPromocionComboEtario> PrPromocionComboEtario { get; set; }
        public virtual ICollection<PrPromocionCombos> PrPromocionCombos { get; set; }
        public virtual ICollection<PrPromocionCupones> PrPromocionCupones { get; set; }
        public virtual ICollection<PrPromocionDescuentoIndividual> PrPromocionDescuentoIndividual { get; set; }
        public virtual ICollection<PrPromocionGrupoFamiliar> PrPromocionGrupoFamiliar { get; set; }
        public virtual ICollection<PrPromocionPaisDestino> PrPromocionPaisDestino { get; set; }
        public virtual ICollection<PrPromocionProducto> PrPromocionProducto { get; set; }
        public virtual ICollection<PrPromocionRangosEtarios> PrPromocionRangosEtarios { get; set; }
        public virtual ICollection<PrSellerIdhabilitadosPromocion> PrSellerIdhabilitadosPromocion { get; set; }
    }
}
