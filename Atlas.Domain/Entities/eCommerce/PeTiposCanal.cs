using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeTiposCanal
    {
        public PeTiposCanal()
        {
            PeCanalesPersona = new HashSet<PeCanalesPersona>();
            PeCanalesPersonaJuridica = new HashSet<PeCanalesPersonaJuridica>();
        }

        public int IdTipoCanal { get; set; }
        public string CodigoTipoCanal { get; set; }
        public string DescripcionTipoCanal { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PeCanalesPersona> PeCanalesPersona { get; set; }
        public virtual ICollection<PeCanalesPersonaJuridica> PeCanalesPersonaJuridica { get; set; }
    }
}
