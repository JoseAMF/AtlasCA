using Atlas.Application.Common.Interfaces;
using Atlas.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atlas.Infrastructure.Services
{
    public class eCommerceDbContextService : IeCommerceDbContextService
    {

        public IConfiguration _configuration;
        private readonly IeCommerceDbContext contextOS;
        private readonly IeCommerceDbContext contextPA;
        private readonly IeCommerceDbContext contextFT;

        public eCommerceDbContextService(IConfiguration configuration, ICurrentUserService currentUserService)
        {
            _configuration = configuration;

            contextOS = new eCommerceDbContext(_configuration.GetConnectionString("e-Commerce_OS"), currentUserService);
            contextPA = new eCommerceDbContext(_configuration.GetConnectionString("e-Commerce_PA"), currentUserService);
            contextFT = new eCommerceDbContext(_configuration.GetConnectionString("Flytour"), currentUserService);
        }

        public IeCommerceDbContext GetContextVoucher(string Voucher)
        {
            switch (Voucher.Substring(0,1))
            {
                case "5": return contextFT;

                case "3": return contextOS;

                case "1": return contextPA;

                default: return contextOS;

            }
        }

        public IeCommerceDbContext GetContextInitials(string Initials)
        {
            switch (Initials)
            {
                case "FT": return contextFT;

                case "OS": return contextOS;

                case "PA": return contextPA;

                default: return contextOS;

            }
        }
    }
}
