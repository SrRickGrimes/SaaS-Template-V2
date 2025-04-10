using Ardalis.Result;
using FastEndpoints;
using Server.Customers.Application.Features.Products.CreateProduct;
using Server.Customers.Domain.Interfaces;

namespace Server.Customers.Infrastructure.Integrations
{
    internal class CreateCustomersCommandHandler(ICustomersService productService) : CommandHandler<CreateCustomersCommand, Result<CreateCustomersCommandResponse>>
    {
        public override async Task<Result<CreateCustomersCommandResponse>> ExecuteAsync(CreateCustomersCommand command, CancellationToken ct = default)
        {
            var product = await productService.CreateProductAsync(
                command.Name,
                command.Description,
                command.Price,
                command.StockQuantity);

            if (product == null)
            {
                return Result<CreateCustomersCommandResponse>.Error("Product creation failed");
            }

            var response = new CreateCustomersCommandResponse(
                 product.Id,
                 product.Name,
                 product.Description,
                 product.Price,
                 product.StockQuantity,
                 product.CreatedAt);

            return Result<CreateCustomersCommandResponse>.Success(response);
        }
    }
}
