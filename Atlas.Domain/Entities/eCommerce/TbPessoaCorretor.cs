using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class TbPessoaCorretor
    {
        public int CdCorretor { get; set; }
        public int IdPessoaCorretor { get; set; }
        public string NmPessoaCorretor { get; set; }
        public string NrCnpjcpf { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
