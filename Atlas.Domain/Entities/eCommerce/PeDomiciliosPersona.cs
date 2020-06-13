using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDomiciliosPersona
    {
        public int IdDomicilioPersona { get; set; }
        public int IdPersona { get; set; }
        public int IdDomicilio { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PeDomicilios IdDomicilioNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
    }
}
