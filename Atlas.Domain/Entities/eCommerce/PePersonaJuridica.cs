using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PePersonaJuridica
    {
        public PePersonaJuridica()
        {
            BsCompanias = new HashSet<BsCompanias>();
            CoAgencias = new HashSet<CoAgencias>();
            CoClientes = new HashSet<CoClientes>();
            CoEmpresas = new HashSet<CoEmpresas>();
            CoPatrocinadores = new HashSet<CoPatrocinadores>();
            CoRepresentantes = new HashSet<CoRepresentantes>();
            PeCanalesPersonaJuridica = new HashSet<PeCanalesPersonaJuridica>();
            PeDomicilioPersonaJuridica = new HashSet<PeDomicilioPersonaJuridica>();
            PrProveedoresServicios = new HashSet<PrProveedoresServicios>();
        }

        public int IdPersonaJuridica { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public int IdResponsableIva { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string NombreFantasia { get; set; }
        public string Iibb { get; set; }

        public virtual CoResponsableIva IdResponsableIvaNavigation { get; set; }
        public virtual ICollection<BsCompanias> BsCompanias { get; set; }
        public virtual ICollection<CoAgencias> CoAgencias { get; set; }
        public virtual ICollection<CoClientes> CoClientes { get; set; }
        public virtual ICollection<CoEmpresas> CoEmpresas { get; set; }
        public virtual ICollection<CoPatrocinadores> CoPatrocinadores { get; set; }
        public virtual ICollection<CoRepresentantes> CoRepresentantes { get; set; }
        public virtual ICollection<PeCanalesPersonaJuridica> PeCanalesPersonaJuridica { get; set; }
        public virtual ICollection<PeDomicilioPersonaJuridica> PeDomicilioPersonaJuridica { get; set; }
        public virtual ICollection<PrProveedoresServicios> PrProveedoresServicios { get; set; }
    }
}
