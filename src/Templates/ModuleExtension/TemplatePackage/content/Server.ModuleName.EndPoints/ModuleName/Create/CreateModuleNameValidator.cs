using FluentValidation;

namespace Server.ModuleName.EndPoints.ModuleName.Create;

internal class CreateModuleNameValidator:AbstractValidator<CreateModuleNameRequest>
{
    public CreateModuleNameValidator()
    {
        RuleFor(x => x.Price).GreaterThan(0);
        RuleFor(x => x.StockQuantity).GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
    }
}
