using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfProductShowCase
    {
        public int ProductShowCaseId { get; set; }
        public int ProductId { get; set; }
        public int RelatedProductId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public string LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual PrProducto Product { get; set; }
        public virtual PrProducto RelatedProduct { get; set; }
    }
}
