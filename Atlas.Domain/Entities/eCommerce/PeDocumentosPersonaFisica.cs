using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDocumentosPersonaFisica
    {
        public int IdDocumentoPersonaFisica { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Numero { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
        public virtual PeTiposDocumentos IdTipoDocumentoNavigation { get; set; }
    }
}
