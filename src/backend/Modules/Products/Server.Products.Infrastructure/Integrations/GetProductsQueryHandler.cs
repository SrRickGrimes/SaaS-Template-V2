using Ardalis.Result;
using FastEndpoints;
using Server.Products.Application.Features.Products.GetProducts;
using Server.Products.Domain.Products;

namespace Server.Products.Infrastructure.Integrations;

internal class GetProductsQueryHandler : CommandHandler<GetProductsQuery, Result<GetProductsQueryResponse>>
{
    public override Task<Result<GetProductsQueryResponse>> ExecuteAsync(GetProductsQuery command, CancellationToken ct = default)
    {
        var products = Enumerable.Range(0, 10).Select(x => new Product(Guid.NewGuid(), $"Product {x}", $"Description {x}", x * x, x, DateTime.UtcNow, true)).ToList();

        return Task.FromResult<Result<GetProductsQueryResponse>>(new GetProductsQueryResponse() { Products = products});
    }
}
