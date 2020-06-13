using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfSession
    {
        public string UserName { get; set; }
        public string SalesChannelType { get; set; }
        public string SalesChannelCode { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string SessionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
