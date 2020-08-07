using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbParentescoPpe
    {
        public int IdParentescoPpe { get; set; }
        public string NmParentescoPpe { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
