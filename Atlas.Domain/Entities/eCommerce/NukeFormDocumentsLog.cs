using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class NukeFormDocumentsLog
    {
        public int IdLog { get; set; }
        public int ModuleId { get; set; }
        public int UserId { get; set; }
        public string Path { get; set; }
        public DateTime FecCreaReg { get; set; }
    }
}
