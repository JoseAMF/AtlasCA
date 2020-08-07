using Atlas.Application.Common.Interfaces;
using Atlas.Infrastructure.Data;
using Atlas.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Atlas.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {
            //Mapeia a implementação a interface
            services.AddScoped<IAtlasDbContext>(provider => provider.GetService<AtlasDbContext>());
            services.AddScoped<IeCommerceDbContext>(provider => provider.GetService<eCommerceDbContext>());
            services.AddScoped<II4ProDbContext>(provider => provider.GetService<I4ProDbContext>());
            services.AddScoped<IPremiumDbContext>(provider => provider.GetService<PremiumDbContext>());

            services.AddScoped<IeCommerceDbContextService, eCommerceDbContextService>();

            services.AddDbContext<AtlasDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
