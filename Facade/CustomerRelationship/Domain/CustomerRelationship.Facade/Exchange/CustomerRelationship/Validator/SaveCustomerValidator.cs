using FluentValidation;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship.Validator
{
    internal class SaveCustomerValidator : AbstractValidator<SaveCustomerInput>
    {
        public SaveCustomerValidator()
        {
            RuleFor(x => x.Customer).NotNull();
        }
    }
}
