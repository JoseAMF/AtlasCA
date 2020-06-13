using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfProductType
    {
        public int ProductTypeId { get; set; }
        public string ProductTypeCode { get; set; }
        public string ProductTypeDescription { get; set; }
        public string CreateBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
