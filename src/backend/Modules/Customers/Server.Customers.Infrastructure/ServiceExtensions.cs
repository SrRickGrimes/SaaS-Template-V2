using Microsoft.Extensions.DependencyInjection;
using Server.Customers.Domain.Interfaces;

namespace Server.Customers.Infrastructure
{
    internal static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICustomersService, CustomersService>();
            return services;
        }
    }
}
