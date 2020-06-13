using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoAutorizacionExtension
    {
        public int IdAutorizacion { get; set; }
        public string VoucherNumber { get; set; }
        public string TravelerNumber { get; set; }
        public string Amount { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
