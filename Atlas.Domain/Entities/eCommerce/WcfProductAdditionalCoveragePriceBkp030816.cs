using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfProductAdditionalCoveragePriceBkp030816
    {
        public int ProductAdditionalCoveragePriceId { get; set; }
        public int ProductId { get; set; }
        public int AdditionalCoverageId { get; set; }
        public int DaysOfCoverage { get; set; }
        public double Amount { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string CreateBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
