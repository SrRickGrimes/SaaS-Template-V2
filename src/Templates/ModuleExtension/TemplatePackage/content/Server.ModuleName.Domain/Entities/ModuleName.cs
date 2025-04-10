namespace Server.ModuleName.Domain.Entities;

internal record ModuleName(Guid Id, string Name, string Description, decimal Price, int StockQuantity, DateTime CreatedAt);
