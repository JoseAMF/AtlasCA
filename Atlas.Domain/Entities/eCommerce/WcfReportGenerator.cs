using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfReportGenerator
    {
        public int ReportGeneratorId { get; set; }
        public string ReportType { get; set; }
        public int AgencyId { get; set; }
        public bool Generate { get; set; }
        public string TemplateName { get; set; }
    }
}
