using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Module.Framework;
using Server.Products.Infrastructure;

namespace Server.Products.Module;

public class ModuleInstaller : IModuleInstaller
{
    public string Name =>nameof(Products);

    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddInfrastructure();
    }

    public void Use(IApplicationBuilder host, IConfiguration configuration)
    {
        throw new NotImplementedException();
    }
}
