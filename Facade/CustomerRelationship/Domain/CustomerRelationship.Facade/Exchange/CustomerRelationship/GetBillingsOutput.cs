using CustomerRelationship.Infrastructure.Model.Exchange;
using CustomerRelationship.Model.Entities;
using System.Collections.Generic;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship
{
    public class GetBillingsOutput : FacadeResponseBase
    {
        public List<Billing> Billings { get; set; }
    }
}
