using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Module.Framework;
using Server.ModuleName.Infrastructure;
using Server.ModuleName.Infrastructure.Configuration;

namespace Server.ModuleName.Module;

public class ModuleInstaller : IModuleInstaller
{
    public string Name =>nameof(ModuleName);

    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        var directory = Path.GetDirectoryName(typeof(ModuleInstaller).Assembly.Location);

        ArgumentException.ThrowIfNullOrEmpty(directory, nameof(directory));

        var currentConfiguration = new ConfigurationBuilder()
         .SetBasePath(directory)
         .AddJsonFile("ModuleName.json", optional: false, reloadOnChange: true)
         .Build();

        services.Configure<ModuleNameConfiguration>(currentConfiguration.GetSection(nameof(ModuleName)));


        services.AddInfrastructure();
    }

    public void Use(IApplicationBuilder host, IConfiguration configuration)
    {
        throw new NotImplementedException();
    }
}
