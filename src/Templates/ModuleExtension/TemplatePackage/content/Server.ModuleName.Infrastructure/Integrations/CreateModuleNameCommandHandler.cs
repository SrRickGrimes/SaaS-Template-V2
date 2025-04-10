using Ardalis.Result;
using FastEndpoints;
using Server.ModuleName.Application.Features.Products.CreateProduct;
using Server.ModuleName.Domain.Interfaces;

namespace Server.ModuleName.Infrastructure.Integrations;

internal class CreateModuleNameCommandHandler(IModuleNameService productService) : CommandHandler<CreateModuleNameCommand, Result<CreateModuleNameCommandResponse>>
{
    public override async Task<Result<CreateModuleNameCommandResponse>> ExecuteAsync(CreateModuleNameCommand command, CancellationToken ct = default)
    {
        var product = await productService.CreateProductAsync(
            command.Name,
            command.Description,
            command.Price,
            command.StockQuantity);

        if (product == null)
        {
            return Result<CreateModuleNameCommandResponse>.Error("Product creation failed");
        }

       var response = new CreateModuleNameCommandResponse(
            product.Id,
            product.Name,
            product.Description,
            product.Price,
            product.StockQuantity,
            product.CreatedAt);

        return Result<CreateModuleNameCommandResponse>.Success(response);
    }
}
