using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfSmsLog
    {
        public int IdSmsLog { get; set; }
        public int IdSmsProceso { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Detalle { get; set; }
    }
}
