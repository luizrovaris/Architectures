using CustomerManager.Infrastructure.Model.Exchange;

namespace CustomerManager.Facade.Exchange.Customer
{
    public class GetCustomerByIdInput : FacadeRequestBase
    {
        public int Id { get; set; }
    }
}
