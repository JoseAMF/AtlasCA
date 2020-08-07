using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCasoComunicacao
    {
        public TbCasoComunicacao()
        {
            TbCasoDocumento = new HashSet<TbCasoDocumento>();
        }

        public int IdCasoComunicacao { get; set; }
        public int IdCaso { get; set; }
        public int IdEventoComunicacao { get; set; }
        public int IdContatoComunicacao { get; set; }
        public int IdTipoDemanda { get; set; }
        public int CdTipoModo { get; set; }
        public string DsContato { get; set; }
        public string DsCasoComunicacao { get; set; }
        public string DsPrestador { get; set; }
        public string NrDocumentoPrestador { get; set; }
        public string DsLocalizacaoPrestador { get; set; }
        public double? VlAutorizado { get; set; }
        public double? VlOrcamento { get; set; }
        public double? VlContratado { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int IdTipoMoeda { get; set; }
        public string AtEstorno { get; set; }
        public string AtFormaContato { get; set; }

        public virtual TbCaso IdCasoNavigation { get; set; }
        public virtual TbTipoContatoComunicacao IdContatoComunicacaoNavigation { get; set; }
        public virtual ICollection<TbCasoDocumento> TbCasoDocumento { get; set; }
    }
}
