using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Common.Interfaces
{
    public interface IeCommerceDbContextService
    {
        IeCommerceDbContext GetContextVoucher(string Voucher);
        IeCommerceDbContext GetContextInitials(string Initials);
    }
}
