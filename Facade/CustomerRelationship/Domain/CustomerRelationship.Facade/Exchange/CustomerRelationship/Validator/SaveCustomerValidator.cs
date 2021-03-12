using FluentValidation;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship.Validator
{
    public class SaveCustomerValidator : AbstractValidator<SaveCustomerInput>
    {
        public SaveCustomerValidator()
        {
            RuleFor(x => x.Customer).NotNull();
        }
    }
}
