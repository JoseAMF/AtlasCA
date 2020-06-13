using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoEjecutivos
    {
        public CoEjecutivos()
        {
            CoAgenciasEjecutivo = new HashSet<CoAgenciasEjecutivo>();
        }

        public int IdEjecutivo { get; set; }
        public int IdPersonaFisica { get; set; }
        public string NumeroLegajo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int IdCompania { get; set; }
        public int UserId { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaFisicaNavigation { get; set; }
        public virtual ICollection<CoAgenciasEjecutivo> CoAgenciasEjecutivo { get; set; }
    }
}
