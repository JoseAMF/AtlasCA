using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoComisionesRepresentante
    {
        public int IdComisionRepresentante { get; set; }
        public int IdRepresentante { get; set; }
        public double Comision { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoRepresentantes IdRepresentanteNavigation { get; set; }
    }
}
