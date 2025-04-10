using Server.Products.Domain.Products;

namespace Server.Products.Domain.Interfaces;

internal interface IProductService
{
    Task<Product> CreateProductAsync(string name, string description, decimal price, int stockQuantity);
}
