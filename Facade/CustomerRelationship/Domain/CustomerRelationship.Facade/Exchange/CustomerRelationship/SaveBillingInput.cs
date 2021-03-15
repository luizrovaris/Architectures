using CustomerRelationship.Infrastructure.Model.Exchange;
using CustomerRelationship.Model.Entities;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship
{
    public class SaveBillingInput : FacadeRequestBase
    {
        public Billing Billing { get; set; }
    }
}
