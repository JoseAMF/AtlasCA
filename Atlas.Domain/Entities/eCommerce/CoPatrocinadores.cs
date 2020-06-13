using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoPatrocinadores
    {
        public CoPatrocinadores()
        {
            CoPatrocinadorMarca = new HashSet<CoPatrocinadorMarca>();
        }

        public int IdPatrocinador { get; set; }
        public int IdPersonaJuridica { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdCompania { get; set; }

        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
        public virtual ICollection<CoPatrocinadorMarca> CoPatrocinadorMarca { get; set; }
    }
}
