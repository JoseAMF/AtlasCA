using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeAutorizacaoAlteracao
    {
        public int IdAutorizacao { get; set; }
        public int? IdAgencia { get; set; }
        public int? Quantidade { get; set; }
        public string CriadoPor { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataModificacao { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
    }
}
