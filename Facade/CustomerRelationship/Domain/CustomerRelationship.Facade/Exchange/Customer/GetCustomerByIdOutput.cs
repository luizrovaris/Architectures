using CustomerRelationship.Infrastructure.Model.Exchange;
using CustomerRelationship.Model.Customer;

namespace CustomerRelationship.Facade.Exchange.Customer
{
    public class GetCustomerByIdOutput : FacadeResponseBase
    {
        public CustomerModel Customer { get; internal set; }
    }
}
