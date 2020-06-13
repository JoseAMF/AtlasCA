using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiSociosEnUsoBup
    {
        public int IdLock { get; set; }
        public string NSoc { get; set; }
        public string NBen { get; set; }
        public string Usuario { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public DateTime? FecBaja { get; set; }
        public int? IdCompania { get; set; }
    }
}
