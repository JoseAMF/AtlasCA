using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbPremiumTipoContaReceber
    {
        public int IdContaReceber { get; set; }
        public int IdTipoContaReceber { get; set; }
        public int IdTipoMovimento { get; set; }
        public string DsTipoContaReceber { get; set; }
        public string DsTipoMovimento { get; set; }
        public string CdTipoPessoa { get; set; }
        public string DsUsuaInclusao { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
