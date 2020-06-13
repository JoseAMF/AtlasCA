using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfProfileRoles
    {
        public int RoleId { get; set; }
        public string UserTypeCode { get; set; }
        public string DnnroleName { get; set; }
    }
}
