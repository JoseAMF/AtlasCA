using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfPoVoucherReasonForCancellation
    {
        public int VoucherReasonForCancellationId { get; set; }
        public int ReasonForCancellationId { get; set; }
        public int VoucherId { get; set; }
        public int BeneficiaryId { get; set; }
    }
}
