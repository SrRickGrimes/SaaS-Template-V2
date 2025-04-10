using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Module.Framework;
using Server.ModuleName.Infrastructure;

namespace Server.ModuleName.Module;

public class ModuleInstaller : IModuleInstaller
{
    public string Name =>nameof(ModuleName);

    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddInfrastructure();
    }

    public void Use(IApplicationBuilder host, IConfiguration configuration)
    {
        throw new NotImplementedException();
    }
}
