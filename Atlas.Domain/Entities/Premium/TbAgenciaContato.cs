using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbAgenciaContato
    {
        public int IdAgenciaContato { get; set; }
        public int IdAgencia { get; set; }
        public string DsAgenciaContato { get; set; }
        public string DsEmail { get; set; }
        public string AtAtivo { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual TbAgencia IdAgenciaNavigation { get; set; }
    }
}
