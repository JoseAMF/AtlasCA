using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfCouponType
    {
        public int CouponTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
