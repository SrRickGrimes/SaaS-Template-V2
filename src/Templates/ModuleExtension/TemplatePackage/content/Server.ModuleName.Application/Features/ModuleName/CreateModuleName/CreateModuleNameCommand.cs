using Ardalis.Result;
using FastEndpoints;

namespace Server.ModuleName.Application.Features.Products.CreateProduct;

internal record CreateModuleNameCommand(
    string Name, 
    string Description, 
    decimal Price, 
    int StockQuantity) :ICommand<Result<CreateModuleNameCommandResponse>>;