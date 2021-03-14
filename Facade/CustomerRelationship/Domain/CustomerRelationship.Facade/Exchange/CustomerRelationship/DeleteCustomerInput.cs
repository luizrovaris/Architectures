using CustomerRelationship.Infrastructure.Model.Exchange;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship
{
    public class DeleteCustomerInput : FacadeRequestBase
    {
        public int CustomerId { get; set; }
    }
}