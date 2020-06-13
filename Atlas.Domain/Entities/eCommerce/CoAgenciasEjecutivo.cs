using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAgenciasEjecutivo
    {
        public int IdAgenciaEjecutivo { get; set; }
        public int IdEjecutivo { get; set; }
        public int IdAgencia { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual CoEjecutivos IdEjecutivoNavigation { get; set; }
    }
}
