namespace Server.Products.EndPoints.GetProducts
{
    internal record ProductItem(Guid Id, string Name, string Description, decimal Price, int StockQuantity, DateTime CreatedAt, bool IsActive);
}
