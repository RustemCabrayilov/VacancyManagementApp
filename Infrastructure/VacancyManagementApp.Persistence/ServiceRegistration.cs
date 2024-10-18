using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VacancyManagementApp.Persistence.Contexts;

namespace VacancyManagementApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));

        }
    }
}
