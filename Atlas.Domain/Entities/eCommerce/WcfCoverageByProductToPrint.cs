using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfCoverageByProductToPrint
    {
        public string ProductCode { get; set; }
        public string AdditionalCoverageCode { get; set; }
        public string CoverageTypeCode { get; set; }
        public string CoverageNamePt { get; set; }
        public string CoverageNameEn { get; set; }
        public string InsuredCapitalPt { get; set; }
        public string InsuredCapitalEn { get; set; }
        public string Franchise { get; set; }
        public string Days { get; set; }
        public double LiquidPriceByDay { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
