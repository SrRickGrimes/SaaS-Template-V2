namespace Server.Customers.Application.Features.Products.CreateProduct
{
    internal record CreateCustomersCommandResponse(Guid Id, string Name, string? Description, decimal Price, int StockQuantity, DateTime CreatedAt);
}
