using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfProfile
    {
        public int ProfileId { get; set; }
        public string Profile { get; set; }
        public int IsValid { get; set; }
    }
}
