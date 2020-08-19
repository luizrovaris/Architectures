using FluentValidation;

namespace CustomerManager.Facade.Exchange.Customer.Validator
{
    public class GetCustomerByIdInputValidator : AbstractValidator<GetCustomerByIdInput>
    {
        public GetCustomerByIdInputValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEqual(0);
        }
    }
}
