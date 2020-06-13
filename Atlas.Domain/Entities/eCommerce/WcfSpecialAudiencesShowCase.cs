using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfSpecialAudiencesShowCase
    {
        public int SpecialAudiencesShowCaseId { get; set; }
        public int SpecialAudiencesId { get; set; }
        public int ProductId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public string LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual PrProducto Product { get; set; }
        public virtual WcfSpecialAudiences SpecialAudiences { get; set; }
    }
}
