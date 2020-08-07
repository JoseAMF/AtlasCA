using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoContatoComunicacao
    {
        public TbTipoContatoComunicacao()
        {
            TbCasoComunicacao = new HashSet<TbCasoComunicacao>();
        }

        public int IdContatoComunicacao { get; set; }
        public string DsContatoComunicacao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual ICollection<TbCasoComunicacao> TbCasoComunicacao { get; set; }
    }
}
