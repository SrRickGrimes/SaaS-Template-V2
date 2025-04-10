namespace Server.ModuleName.Domain.Products;

internal record Product(Guid Id, string Name, string Description, decimal Price, int StockQuantity, DateTime CreatedAt);
