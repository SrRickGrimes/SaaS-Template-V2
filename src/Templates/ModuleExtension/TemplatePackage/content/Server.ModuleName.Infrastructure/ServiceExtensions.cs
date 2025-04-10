using Microsoft.Extensions.DependencyInjection;
using Server.ModuleName.Domain.Interfaces;

namespace Server.ModuleName.Infrastructure;

internal static class ServiceExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IProductService, ProductService>();
        return services;
    }
}
