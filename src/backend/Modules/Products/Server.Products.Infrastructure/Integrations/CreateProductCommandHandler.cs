using Ardalis.Result;
using FastEndpoints;
using Server.Products.Application.Features.Products.CreateProduct;
using Server.Products.Domain.Interfaces;

namespace Server.Products.Infrastructure.Integrations;

internal class CreateProductCommandHandler(IProductService productService) : CommandHandler<CreateProductCommand, Result<CreateProductCommandResponse>>
{
    public override async Task<Result<CreateProductCommandResponse>> ExecuteAsync(CreateProductCommand command, CancellationToken ct = default)
    {
        var product = await productService.CreateProductAsync(
            command.Name,
            command.Description,
            command.Price,
            command.StockQuantity);

        if (product == null)
        {
            return Result<CreateProductCommandResponse>.Error("Product creation failed");
        }

       var response = new CreateProductCommandResponse(
            product.Id,
            product.Name,
            product.Description,
            product.Price,
            product.StockQuantity,
            product.CreatedAt);

        return Result<CreateProductCommandResponse>.Success(response);
    }
}
