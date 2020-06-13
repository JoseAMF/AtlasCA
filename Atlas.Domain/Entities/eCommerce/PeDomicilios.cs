using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDomicilios
    {
        public PeDomicilios()
        {
            PeDomicilioPersonaJuridica = new HashSet<PeDomicilioPersonaJuridica>();
            PeDomiciliosAgenciasCobranza = new HashSet<PeDomiciliosAgenciasCobranza>();
            PeDomiciliosPersona = new HashSet<PeDomiciliosPersona>();
        }

        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string DeptoOficina { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdPais { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdTipoCalle { get; set; }
        public string Barrio { get; set; }

        public virtual BsPaises IdPaisNavigation { get; set; }
        public virtual BsProvincias IdProvinciaNavigation { get; set; }
        public virtual PeTiposCalle IdTipoCalleNavigation { get; set; }
        public virtual ICollection<PeDomicilioPersonaJuridica> PeDomicilioPersonaJuridica { get; set; }
        public virtual ICollection<PeDomiciliosAgenciasCobranza> PeDomiciliosAgenciasCobranza { get; set; }
        public virtual ICollection<PeDomiciliosPersona> PeDomiciliosPersona { get; set; }
    }
}
