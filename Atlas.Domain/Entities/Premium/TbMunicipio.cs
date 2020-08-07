using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbMunicipio
    {
        public int IdMunicipio { get; set; }
        public string DsMunicipio { get; set; }
        public int? IdUf { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
