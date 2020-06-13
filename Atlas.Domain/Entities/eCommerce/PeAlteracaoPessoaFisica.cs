using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeAlteracaoPessoaFisica
    {
        public int IdAlteracao { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdAgencia { get; set; }
        public DateTime? DataCadastro { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual PePersonaFisica IdPessoaNavigation { get; set; }
    }
}
