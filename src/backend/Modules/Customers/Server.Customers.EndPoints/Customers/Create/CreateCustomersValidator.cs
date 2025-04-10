using FluentValidation;

namespace Server.Customers.EndPoints.Customers.Create
{
    internal class CreateCustomersValidator : AbstractValidator<CreateCustomersRequest>
    {
        public CreateCustomersValidator()
        {
            RuleFor(x => x.Price).GreaterThan(0);
            RuleFor(x => x.StockQuantity).GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
