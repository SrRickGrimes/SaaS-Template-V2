namespace Server.Products.Application.Features.Products.CreateProduct;

internal record CreateProductCommandResponse(Guid Id, string Name, string? Description, decimal Price, int StockQuantity, DateTime CreatedAt);
