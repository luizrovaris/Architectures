using CustomerRelationship.Infrastructure.Model.Exchange;

namespace CustomerRelationship.Facade.Exchange.Customer
{
    public class GetCustomerByIdInput : FacadeRequestBase
    {
        public int Id { get; set; }
    }
}
