using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class Html
    {
        public int IdRelatorio { get; set; }
        public string DsRelatorio { get; set; }
        public string StrHtml { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
