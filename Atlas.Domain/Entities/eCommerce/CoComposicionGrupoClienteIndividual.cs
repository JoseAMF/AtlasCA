using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoComposicionGrupoClienteIndividual
    {
        public int IdGrupoFamiliarIndividuo { get; set; }
        public int IdClienteIndividual { get; set; }
        public int IdPersona { get; set; }
        public int? IdParentesco { get; set; }
        public bool MarcaTitular { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoClientesIndividuales IdClienteIndividualNavigation { get; set; }
        public virtual PoParentesco IdParentescoNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
    }
}
