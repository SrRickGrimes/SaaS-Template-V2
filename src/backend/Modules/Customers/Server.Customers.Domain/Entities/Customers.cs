namespace Server.Customers.Domain.Entities
{
    internal record Customers(Guid Id, string Name, string Description, decimal Price, int StockQuantity, DateTime CreatedAt);
}
