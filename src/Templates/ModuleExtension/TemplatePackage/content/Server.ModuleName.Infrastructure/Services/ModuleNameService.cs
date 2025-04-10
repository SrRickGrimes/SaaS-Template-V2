

using Server.ModuleName.Domain.Entities;
using Server.ModuleName.Domain.Interfaces;

internal class ModuleNameService : IModuleNameService
{
    public async Task<ModuleName> CreateProductAsync(string name, string description, decimal price, int stockQuantity)
    {
        var item = new ModuleName(Guid.NewGuid(),name, description, price, stockQuantity, DateTime.UtcNow);

        await Task.Delay(100);

        return item;
    }
}
