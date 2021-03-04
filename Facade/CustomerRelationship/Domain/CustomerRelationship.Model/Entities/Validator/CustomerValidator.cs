using FluentValidation;

namespace CustomerRelationship.Model.Entities.Validator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}
