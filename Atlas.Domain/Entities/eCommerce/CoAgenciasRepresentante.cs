using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAgenciasRepresentante
    {
        public int IdAgenciaRepresentante { get; set; }
        public int IdRepresentante { get; set; }
        public int IdAgencia { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual CoRepresentantes IdRepresentanteNavigation { get; set; }
    }
}
