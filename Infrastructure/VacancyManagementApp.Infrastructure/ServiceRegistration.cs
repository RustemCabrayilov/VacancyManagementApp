using Microsoft.Extensions.DependencyInjection;
using VacancyManagementApp.Application.Abstractions.Token;
using VacancyManagementApp.Infrastructure.Services.Token;

namespace VacancyManagementApp.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
