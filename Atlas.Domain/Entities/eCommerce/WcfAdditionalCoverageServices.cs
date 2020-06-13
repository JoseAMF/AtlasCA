using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfAdditionalCoverageServices
    {
        public int AdditionalCoverageServiceId { get; set; }
        public int AdditionalCoveragelId { get; set; }
        public int ServiceId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int UnitOfMeasureId { get; set; }
        public int CurrencyId { get; set; }
        public double MaxCoverage { get; set; }
        public string Detail { get; set; }
        public string EnglishDetail { get; set; }
        public int MainFeature { get; set; }
        public string CreateBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
