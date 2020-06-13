using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsPaises
    {
        public BsPaises()
        {
            BsProvincias = new HashSet<BsProvincias>();
            CoCotizacionesIndividuosLog = new HashSet<CoCotizacionesIndividuosLog>();
            CoDetallesVentaPacksOnline = new HashSet<CoDetallesVentaPacksOnline>();
            MiCorresponsalesBup = new HashSet<MiCorresponsalesBup>();
            MiPaisesAtencionCorresponsales = new HashSet<MiPaisesAtencionCorresponsales>();
            PeDomicilios = new HashSet<PeDomicilios>();
            PePersonaFisica = new HashSet<PePersonaFisica>();
            PrPromocionPaisDestino = new HashSet<PrPromocionPaisDestino>();
            WcfDestinyShowCase = new HashSet<WcfDestinyShowCase>();
        }

        public int IdPais { get; set; }
        public string CodigoPais { get; set; }
        public string DenominacionPais { get; set; }
        public int? DiferenciaHoraria { get; set; }
        public string ContactoIag { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string Iso3l { get; set; }
        public int? Orden { get; set; }
        public int? IdContinente { get; set; }
        public int? Euro { get; set; }
        public int? ProductTypeId { get; set; }

        public virtual ICollection<BsProvincias> BsProvincias { get; set; }
        public virtual ICollection<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<CoDetallesVentaPacksOnline> CoDetallesVentaPacksOnline { get; set; }
        public virtual ICollection<MiCorresponsalesBup> MiCorresponsalesBup { get; set; }
        public virtual ICollection<MiPaisesAtencionCorresponsales> MiPaisesAtencionCorresponsales { get; set; }
        public virtual ICollection<PeDomicilios> PeDomicilios { get; set; }
        public virtual ICollection<PePersonaFisica> PePersonaFisica { get; set; }
        public virtual ICollection<PrPromocionPaisDestino> PrPromocionPaisDestino { get; set; }
        public virtual ICollection<WcfDestinyShowCase> WcfDestinyShowCase { get; set; }
    }
}
