﻿using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDocumentosPersonaJuridica
    {
        public int IdDocumentoPersonaJuridica { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Numero { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PeTiposDocumentos IdTipoDocumentoNavigation { get; set; }
    }
}
