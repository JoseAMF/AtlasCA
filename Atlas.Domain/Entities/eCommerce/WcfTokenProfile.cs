using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfTokenProfile
    {
        public int IdTokenProfile { get; set; }
        public string Token { get; set; }
        public string Profile { get; set; }
    }
}
