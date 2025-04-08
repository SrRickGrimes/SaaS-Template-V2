

using Server.ModuleName.Domain.Interfaces;
using Server.ModuleName.Domain.Products;

internal class ProductService : IProductService
{
    public async Task<Product> CreateProductAsync(string name, string description, decimal price, int stockQuantity)
    {
        var product = new Product(Guid.NewGuid(),name, description, price, stockQuantity, DateTime.UtcNow);

        await Task.Delay(100);

        return product;
    }
}
