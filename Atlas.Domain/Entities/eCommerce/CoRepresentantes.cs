using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoRepresentantes
    {
        public CoRepresentantes()
        {
            CoAgenciasRepresentante = new HashSet<CoAgenciasRepresentante>();
            CoComisionesRepresentante = new HashSet<CoComisionesRepresentante>();
        }

        public int IdRepresentante { get; set; }
        public int IdPersonaJuridica { get; set; }
        public string Contacto { get; set; }
        public DateTime FechaRevision { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int IdCompania { get; set; }
        public int UserId { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
        public virtual ICollection<CoAgenciasRepresentante> CoAgenciasRepresentante { get; set; }
        public virtual ICollection<CoComisionesRepresentante> CoComisionesRepresentante { get; set; }
    }
}
