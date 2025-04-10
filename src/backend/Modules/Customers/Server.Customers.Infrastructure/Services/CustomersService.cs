

using Server.Customers.Domain.Entities;
using Server.Customers.Domain.Interfaces;

internal class CustomersService : ICustomersService
{
    public async Task<Customers> CreateProductAsync(string name, string description, decimal price, int stockQuantity)
    {
        var item = new Customers(Guid.NewGuid(), name, description, price, stockQuantity, DateTime.UtcNow);

        await Task.Delay(100);

        return item;
    }
}
