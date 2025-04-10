namespace Server.ModuleName.EndPoints.ModuleName.Create;

public class CreateModuleNameRequest
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}
