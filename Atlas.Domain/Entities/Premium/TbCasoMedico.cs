using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCasoMedico
    {
        public int IdCasoMedico { get; set; }
        public int IdCaso { get; set; }
        public int IdTipoAssistencia { get; set; }
        public string DsAssistenciaRequerida { get; set; }
        public string DsLocalizacaoBeneficiario { get; set; }
        public string DsRelatorioMedico { get; set; }
        public DateTime? DtInternacao { get; set; }
        public DateTime? DtAlta { get; set; }
        public string DsCid { get; set; }
        public double? VlLimiteCobertura { get; set; }
        public string AtLimite { get; set; }
        public DateTime? DtLimite { get; set; }
        public int? NrAutorizacaoOmint { get; set; }
        public string DsNomeAcompanhante { get; set; }
        public string NrTelefoneAcompanhante { get; set; }
        public string CdTipoPrestador { get; set; }
        public string AtCredenciado { get; set; }
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
