using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfToken
    {
        public string Username { get; set; }
        public string SalesChannelType { get; set; }
        public string SalesChannelCode { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Token { get; set; }
        public DateTime Created { get; set; }
        public int IsValid { get; set; }
    }
}
