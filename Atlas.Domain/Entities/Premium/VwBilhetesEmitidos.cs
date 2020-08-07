using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class VwBilhetesEmitidos
    {
        public string Operacao { get; set; }
        public string NmCorretor { get; set; }
        public string NrVoucher { get; set; }
        public DateTime DtCotacao { get; set; }
        public string NrCpf { get; set; }
        public string NmSegurado { get; set; }
        public decimal? VlPremioLiquido { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public DateTime? DtInicioViagem { get; set; }
        public DateTime? DtFimViagem { get; set; }
        public string CdProduto { get; set; }
        public int? Tgp { get; set; }
        public int? Tgi { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DtArquivo { get; set; }
    }
}
