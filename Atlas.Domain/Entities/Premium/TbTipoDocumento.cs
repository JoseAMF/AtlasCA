using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoDocumento
    {
        public int IdTipoDocumento { get; set; }
        public string CdTipoDocumento { get; set; }
        public string DsTipoDocumento { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
