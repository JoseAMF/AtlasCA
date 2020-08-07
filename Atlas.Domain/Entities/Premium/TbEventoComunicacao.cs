using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbEventoComunicacao
    {
        public int IdEventoComunicacao { get; set; }
        public string DsEventoComunicacao { get; set; }
        public string AtComplemento { get; set; }
        public string AtLimite { get; set; }
        public string AtTipoAssistencia { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
