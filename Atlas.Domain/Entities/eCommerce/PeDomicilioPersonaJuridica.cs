﻿using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDomicilioPersonaJuridica
    {
        public int IdDomicilioPersonaJuridica { get; set; }
        public int IdPersonaJuridica { get; set; }
        public int IdDomicilio { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PeDomicilios IdDomicilioNavigation { get; set; }
        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
    }
}
