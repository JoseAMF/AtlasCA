using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCasoViagem
    {
        public int IdCasoViagem { get; set; }
        public int IdCaso { get; set; }
        public int IdTipoAssistencia { get; set; }
        public string DsDetalheSolicitacao { get; set; }
        public string DsLocalizacaoBeneficiario { get; set; }
        public string DsComentario { get; set; }
        public double? VlLimiteCobertura { get; set; }
        public double? VlContratado { get; set; }
        public double? VlOrcamento { get; set; }
        public string DsPrestador { get; set; }
        public string NrDocumentoPrestador { get; set; }
        public string DsLocalizacaoPrestador { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int? IdTipoMoeda { get; set; }

        public virtual TbCaso IdCasoNavigation { get; set; }
    }
}
