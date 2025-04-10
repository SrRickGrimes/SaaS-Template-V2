namespace Server.Customers.EndPoints.Customers.Create
{
    public record CreateCustomersResponse(Guid Id, string Name, string? Description, decimal Price, int StockQuantity, DateTime CreatedAt);
}
