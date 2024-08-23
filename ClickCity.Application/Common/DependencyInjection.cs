using Microsoft.Extensions.DependencyInjection;

namespace ClickCity.Application.Common
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddLogging();
            services.AddScoped<ScopeCache>();

            return services;
        }
    }
}