using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDomiciliosAgenciasCobranza
    {
        public int IdAgenciaCobranzaDomicilio { get; set; }
        public int? IdAgenciaCobranza { get; set; }
        public int? IdDomicilio { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoAgenciasCobranza IdAgenciaCobranzaNavigation { get; set; }
        public virtual PeDomicilios IdDomicilioNavigation { get; set; }
    }
}
