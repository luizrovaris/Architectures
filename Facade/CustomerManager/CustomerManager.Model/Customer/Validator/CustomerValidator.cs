using FluentValidation;

namespace CustomerManager.Model.Customer.Validator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}
