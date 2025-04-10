using Microsoft.Extensions.DependencyInjection;
using Server.Products.Domain.Interfaces;

namespace Server.Products.Infrastructure;

internal static class ServiceExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IProductService, ProductService>();
        return services;
    }
}
