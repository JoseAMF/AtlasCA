using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class VwApoliceCrm
    {
        public int? NrApolice { get; set; }
        public string NrBilhete { get; set; }
        public string DsProduto { get; set; }
        public string DtEmissao { get; set; }
        public string DtInicioViagem { get; set; }
        public string DtFimViagem { get; set; }
        public int? CdRepresentante { get; set; }
        public string CpfCnpjRepresentante { get; set; }
        public int? CdCorretor { get; set; }
        public string CpfCnpjCorretor { get; set; }
        public int? CdVendedor { get; set; }
        public string CpfCnpjVendedor { get; set; }
        public string DsPaisDestinoViagem { get; set; }
        public decimal? VlCotacao { get; set; }
        public string DsFile { get; set; }
        public decimal? PeDesconto { get; set; }
        public decimal? VlPremio { get; set; }
        public string NmSegurado { get; set; }
        public string NrCpf { get; set; }
    }
}
