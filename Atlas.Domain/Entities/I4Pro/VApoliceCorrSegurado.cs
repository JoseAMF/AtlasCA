using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.I4Pro
{
    public partial class VApoliceCorrSegurado
    {
        public decimal? CdApolice { get; set; }
        public DateTime? DtEmissaoApolice { get; set; }
        public long? NrCnpjCpfCli { get; set; }
        public long? NrCertificado { get; set; }
        public string NrBilhete { get; set; }
        public long? CdProposta { get; set; }
        public string CdSusep { get; set; }
        public int? CdCorretor { get; set; }
        public string NmCorretor { get; set; }
        public string NmSegurado { get; set; }
        public DateTime? DtNascSeg { get; set; }
        public string CepSegurad { get; set; }
        public string SexoSegurado { get; set; }
    }
}
