using Ardalis.Result;
using FastEndpoints;

namespace Server.Customers.Application.Features.Products.CreateProduct
{
    internal record CreateCustomersCommand(
        string Name,
        string Description,
        decimal Price,
        int StockQuantity) : ICommand<Result<CreateCustomersCommandResponse>>;
}