using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeTiposDocumentos
    {
        public PeTiposDocumentos()
        {
            PeDocumentosPersonaFisica = new HashSet<PeDocumentosPersonaFisica>();
            PeDocumentosPersonaJuridica = new HashSet<PeDocumentosPersonaJuridica>();
        }

        public int IdTipoDocumento { get; set; }
        public string CodigoTipoDocumento { get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public string AplicaPersona { get; set; }
        public string AplicaEmision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PeDocumentosPersonaFisica> PeDocumentosPersonaFisica { get; set; }
        public virtual ICollection<PeDocumentosPersonaJuridica> PeDocumentosPersonaJuridica { get; set; }
    }
}
