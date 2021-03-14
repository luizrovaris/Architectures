using FluentValidation;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship.Validator
{
    internal class DeleteCustomerValidator : AbstractValidator<DeleteCustomerInput>
    {
        public DeleteCustomerValidator()
        {
            RuleFor(x => x.CustomerId).GreaterThan(0);
        }
    }
}
