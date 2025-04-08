﻿
namespace Server.ModuleName.EndPoints.CreateProduct;

public record CreateProductResponse(Guid Id, string Name, string? Description, decimal Price, int StockQuantity, DateTime CreatedAt);
