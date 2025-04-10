namespace Server.ModuleName.Domain.Interfaces;

internal interface IModuleNameService
{
    Task<Entities.ModuleName> CreateProductAsync(string name, string description, decimal price, int stockQuantity);
}
