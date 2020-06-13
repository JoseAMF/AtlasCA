using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfReasonForCancellation
    {
        public int ReasonForCancellationId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
