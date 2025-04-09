using Ardalis.Result;
using FastEndpoints;

namespace Server.Products.Application.Features.Products.GetProducts;

internal record GetProductsQuery(bool IncludeInactive):ICommand<Result<GetProductsQueryResponse>>;
