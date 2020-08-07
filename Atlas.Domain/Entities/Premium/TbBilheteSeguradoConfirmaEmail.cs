using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbBilheteSeguradoConfirmaEmail
    {
        public string NrBilhete { get; set; }
        public DateTime? DhAgenda { get; set; }
        public DateTime? DhEnvio { get; set; }
    }
}
