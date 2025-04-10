using Server.ModuleName.Domain.Products;

namespace Server.ModuleName.Domain.Interfaces;

internal interface IProductService
{
    Task<Product> CreateProductAsync(string name, string description, decimal price, int stockQuantity);
}
