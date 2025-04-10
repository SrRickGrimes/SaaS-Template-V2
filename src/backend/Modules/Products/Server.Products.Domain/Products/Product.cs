namespace Server.Products.Domain.Products;

internal record Product(Guid Id, string Name, string Description, decimal Price, int StockQuantity, DateTime CreatedAt, bool IsActive);
