namespace Server.ModuleName.Application.Features.Products.CreateProduct;

internal record CreateModuleNameCommandResponse(Guid Id, string Name, string? Description, decimal Price, int StockQuantity, DateTime CreatedAt);
