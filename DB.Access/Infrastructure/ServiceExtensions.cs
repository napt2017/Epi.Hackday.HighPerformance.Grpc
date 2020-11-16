using DB.Access.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DB.Access.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigureEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EpiHackdayDbContext>(optionBuilder => optionBuilder.UseSqlite(connectionString));
            services.AddScoped<IEpiHackdayRepository, EpiHackdayRepository>();
        }
    }
}
