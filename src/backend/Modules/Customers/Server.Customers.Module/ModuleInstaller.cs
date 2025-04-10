using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Customers.Infrastructure;
using Server.Customers.Infrastructure.Configuration;
using Server.Module.Framework;

namespace Server.Customers.Module
{
    public class ModuleInstaller : IModuleInstaller
    {
        public string Name => nameof(Customers);

        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            var directory = Path.GetDirectoryName(typeof(ModuleInstaller).Assembly.Location);

            ArgumentException.ThrowIfNullOrEmpty(directory, nameof(directory));

            var currentConfiguration = new ConfigurationBuilder()
             .SetBasePath(directory)
             .AddJsonFile("Customers.json", optional: false, reloadOnChange: true)
             .Build();

            services.Configure<CustomersConfiguration>(currentConfiguration.GetSection(nameof(Customers)));


            services.AddInfrastructure();
        }

        public void Use(IApplicationBuilder host, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
