using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfContactUsBlogger
    {
        public int ContactUsBloggerId { get; set; }
        public string FullName { get; set; }
        public string Blog { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
