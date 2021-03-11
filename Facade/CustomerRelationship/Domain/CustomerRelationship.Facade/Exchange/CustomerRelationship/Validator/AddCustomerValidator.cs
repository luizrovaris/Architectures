using FluentValidation;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship.Validator
{
    public class AddCustomerValidator : AbstractValidator<AddCustomerInput>
    {
        public AddCustomerValidator()
        {
            RuleFor(x => x.Customer).NotNull();
        }
    }
}
