namespace Server.Customers.Domain.Interfaces
{
    internal interface ICustomersService
    {
        Task<Entities.Customers> CreateProductAsync(string name, string description, decimal price, int stockQuantity);
    }
}
