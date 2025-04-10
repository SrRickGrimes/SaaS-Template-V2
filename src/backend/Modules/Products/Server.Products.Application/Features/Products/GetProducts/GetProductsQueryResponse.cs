using Server.Products.Domain.Products;

namespace Server.Products.Application.Features.Products.GetProducts;

internal class GetProductsQueryResponse
{
    public List<Product> Products { get; set; } = [];
}
