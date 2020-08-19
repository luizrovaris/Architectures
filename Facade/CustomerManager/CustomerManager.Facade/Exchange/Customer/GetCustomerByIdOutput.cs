using CustomerManager.Infrastructure.Model.Exchange;

namespace CustomerManager.Facade.Exchange.Customer
{
    public class GetCustomerByIdOutput : FacadeResponseBase
    {
        public Model.Customer.Customer Customer { get; internal set; }
    }
}
