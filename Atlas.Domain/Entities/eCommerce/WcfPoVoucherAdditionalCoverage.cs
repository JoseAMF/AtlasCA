using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfPoVoucherAdditionalCoverage
    {
        public int VoucherAdditionalCoverageId { get; set; }
        public int VoucherId { get; set; }
        public int AdditionalCoverageId { get; set; }
        public double? Amount { get; set; }
        public double? CompanyAmount { get; set; }
        public int? ProductId { get; set; }

        public virtual WcfAdditionalCoverage AdditionalCoverage { get; set; }
    }
}
