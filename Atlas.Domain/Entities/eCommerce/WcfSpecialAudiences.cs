using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfSpecialAudiences
    {
        public WcfSpecialAudiences()
        {
            WcfSpecialAudiencesShowCase = new HashSet<WcfSpecialAudiencesShowCase>();
        }

        public int SpecialAudiencesId { get; set; }
        public string SpecialAudienceCode { get; set; }
        public string SpecialAudienceName { get; set; }
        public string LandingPage { get; set; }

        public virtual ICollection<WcfSpecialAudiencesShowCase> WcfSpecialAudiencesShowCase { get; set; }
    }
}
