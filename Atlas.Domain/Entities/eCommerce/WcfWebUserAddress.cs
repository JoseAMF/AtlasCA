using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfWebUserAddress
    {
        public int WebUserAddressId { get; set; }
        public int? WebUserId { get; set; }
        public int? AddressId { get; set; }
    }
}
