using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoParentesco
    {
        public PoParentesco()
        {
            CoComposicionGrupoClienteIndividual = new HashSet<CoComposicionGrupoClienteIndividual>();
            PoBeneficiariosPoliza = new HashSet<PoBeneficiariosPoliza>();
            PoRelacionParentescoWs = new HashSet<PoRelacionParentescoWs>();
        }

        public int IdParentesco { get; set; }
        public string CodigoParentesco { get; set; }
        public string DescripcionParentesco { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<CoComposicionGrupoClienteIndividual> CoComposicionGrupoClienteIndividual { get; set; }
        public virtual ICollection<PoBeneficiariosPoliza> PoBeneficiariosPoliza { get; set; }
        public virtual ICollection<PoRelacionParentescoWs> PoRelacionParentescoWs { get; set; }
    }
}
