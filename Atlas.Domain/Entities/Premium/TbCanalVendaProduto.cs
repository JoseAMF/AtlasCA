using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCanalVendaProduto
    {
        public int IdCanalVenda { get; set; }
        public string DsCanalVenda { get; set; }
        public string CdProduto { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
