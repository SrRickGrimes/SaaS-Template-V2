namespace Server.ModuleName.EndPoints.ModuleName.Create;

public record CreateModuleNameResponse(Guid Id, string Name, string? Description, decimal Price, int StockQuantity, DateTime CreatedAt);
