using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.I4Pro
{
    public partial class VSinistroCovidSusep
    {
        public string CodCia { get; set; }
        public string Mesano { get; set; }
        public string Gruporamo { get; set; }
        public long Numsin { get; set; }
        public string StatusSin { get; set; }
        public string DataAviso { get; set; }
        public string DataOcorr { get; set; }
        public string DataFim { get; set; }
        public decimal? ValorSin { get; set; }
        public string Uf { get; set; }
        public int? Idade { get; set; }
        public string DtIdentificacao { get; set; }
    }
}
