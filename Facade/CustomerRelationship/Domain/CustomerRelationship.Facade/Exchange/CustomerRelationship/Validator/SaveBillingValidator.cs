using FluentValidation;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship.Validator
{
    internal class SaveBillingValidator : AbstractValidator<SaveBillingInput>
    {
        public SaveBillingValidator()
        {
            RuleFor(x => x.Billing).NotNull();
        }
    }
}
