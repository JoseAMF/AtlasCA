using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiPaisesAtencionCorresponsales
    {
        public int IdPaisAtencionCorresponsal { get; set; }
        public int IdCorresponsal { get; set; }
        public int IdPais { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual MiCorresponsales IdCorresponsalNavigation { get; set; }
        public virtual BsPaises IdPaisNavigation { get; set; }
    }
}
