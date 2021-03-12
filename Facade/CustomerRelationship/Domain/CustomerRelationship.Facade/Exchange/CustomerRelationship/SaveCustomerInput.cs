using CustomerRelationship.Infrastructure.Model.Exchange;
using CustomerRelationship.Model.Entities;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship
{
    public class SaveCustomerInput : FacadeRequestBase
    {
        public Customer Customer { get; set; }
    }
}
