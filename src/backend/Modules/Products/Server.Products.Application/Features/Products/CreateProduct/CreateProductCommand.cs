using Ardalis.Result;
using FastEndpoints;

namespace Server.Products.Application.Features.Products.CreateProduct;

internal record CreateProductCommand(
    string Name, 
    string Description, 
    decimal Price, 
    int StockQuantity) :ICommand<Result<CreateProductCommandResponse>>;