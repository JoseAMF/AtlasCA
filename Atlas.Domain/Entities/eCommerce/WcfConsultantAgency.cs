using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfConsultantAgency
    {
        public int ConsultantAgencyId { get; set; }
        public int? ConsultantId { get; set; }
        public int? AgencyId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? VadlidTo { get; set; }
        public string CreationBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
