using Ardalis.Result;
using FastEndpoints;
using Microsoft.AspNetCore.Http;
using Server.Products.Application.Features.Products.GetProducts;

namespace Server.Products.EndPoints.GetProducts;

internal class GetProductsEndPoint:Endpoint<GetProductsRequest,GetProductsResponse>
{
    public override void Configure()
    {
        Get("/");
        Group<ProductGroup>();
        AllowAnonymous();
        Description(d => d
            .Produces<GetProductsResponse>()
            .Produces(StatusCodes.Status500InternalServerError));
    }

    public override async Task HandleAsync(GetProductsRequest req, CancellationToken ct)
    {
        var command = new GetProductsQuery(req.IncludeInactive);

        var result = await command.ExecuteAsync(ct: ct);

        if (result.IsSuccess)
        {
            var products = result.Value.Products.Select(x => new ProductItem(
                x.Id, 
                x.Name, 
                x.Description, 
                x.Price, 
                x.StockQuantity, 
                x.CreatedAt, 
                x.IsActive)).ToList();
            await SendOkAsync(new GetProductsResponse(products), ct);
            return;
        }

        switch (result.Status)
        {
            case ResultStatus.Invalid:
                foreach (var error in result.ValidationErrors)
                {
                    AddError(error.Identifier, error.ErrorMessage);
                }
                await SendErrorsAsync(StatusCodes.Status400BadRequest, ct);
                break;

            case ResultStatus.NotFound:
                AddError("Products not found");
                await SendErrorsAsync(StatusCodes.Status404NotFound, ct);
                break;

            default:
                AddError("Error processing the request");
                await SendErrorsAsync(StatusCodes.Status500InternalServerError, ct);
                break;
        }
    }
}
