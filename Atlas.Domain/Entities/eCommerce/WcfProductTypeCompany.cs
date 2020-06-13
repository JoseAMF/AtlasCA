using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WcfProductTypeCompany
    {
        public int ProductTypeCompanyId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? CompanyId { get; set; }
    }
}
