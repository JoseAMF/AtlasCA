using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoAssistencia
    {
        public int IdTipoAssistencia { get; set; }
        public string AtTipoAssistencia { get; set; }
        public string DsTipoAssistencia { get; set; }
        public string DsTipoAssistenciaEn { get; set; }
        public string AtLimite { get; set; }
        public string AtStatus { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
