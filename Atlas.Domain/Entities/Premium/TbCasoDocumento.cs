using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCasoDocumento
    {
        public int IdCasoDocumento { get; set; }
        public int IdCasoComunicacao { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdImagem { get; set; }
        public string DsComentario { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual TbCasoComunicacao IdCasoComunicacaoNavigation { get; set; }
    }
}
