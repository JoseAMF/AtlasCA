using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfProfilePermission
    {
        public int ProfilePermissionId { get; set; }
        public int ProfileId { get; set; }
        public string Service { get; set; }
        public string Method { get; set; }
        public int IsValid { get; set; }
    }
}
