using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoResponsableIva
    {
        public CoResponsableIva()
        {
            PePersonaJuridica = new HashSet<PePersonaJuridica>();
        }

        public int IdResponsableIva { get; set; }
        public string DescripcionResponsableIva { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PePersonaJuridica> PePersonaJuridica { get; set; }
    }
}
