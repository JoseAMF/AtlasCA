using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsCompanias
    {
        public BsCompanias()
        {
            CoEjecutivos = new HashSet<CoEjecutivos>();
            CoRepresentantes = new HashSet<CoRepresentantes>();
            PeTiposCalle = new HashSet<PeTiposCalle>();
            PrGruposAfinidad = new HashSet<PrGruposAfinidad>();
            PrLineaProducto = new HashSet<PrLineaProducto>();
            PrPromociones = new HashSet<PrPromociones>();
            PrTiposObjetivosAgencias = new HashSet<PrTiposObjetivosAgencias>();
            PrTiposPromocion = new HashSet<PrTiposPromocion>();
            PrZonasImpresionServicios = new HashSet<PrZonasImpresionServicios>();
        }

        public int IdCompania { get; set; }
        public int? IdPersonaJuridica { get; set; }
        public string RequiereCondicionAceptacion { get; set; }
        public DateTime? FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string Idioma { get; set; }
        public int? PortalId { get; set; }

        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
        public virtual ICollection<CoEjecutivos> CoEjecutivos { get; set; }
        public virtual ICollection<CoRepresentantes> CoRepresentantes { get; set; }
        public virtual ICollection<PeTiposCalle> PeTiposCalle { get; set; }
        public virtual ICollection<PrGruposAfinidad> PrGruposAfinidad { get; set; }
        public virtual ICollection<PrLineaProducto> PrLineaProducto { get; set; }
        public virtual ICollection<PrPromociones> PrPromociones { get; set; }
        public virtual ICollection<PrTiposObjetivosAgencias> PrTiposObjetivosAgencias { get; set; }
        public virtual ICollection<PrTiposPromocion> PrTiposPromocion { get; set; }
        public virtual ICollection<PrZonasImpresionServicios> PrZonasImpresionServicios { get; set; }
    }
}
