using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfBlackList
    {
        public int BlackListId { get; set; }
        public int IdentityDocumentTypeId { get; set; }
        public string IdentityDocumentNumber { get; set; }
        public string IdentityDocumentNumberFiltered { get; set; }
    }
}
