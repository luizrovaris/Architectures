using CustomerRelationship.Infrastructure.Model.Exchange;
using CustomerRelationship.Model.Entities;
using System.Collections.Generic;

namespace CustomerRelationship.Facade.Exchange.CustomerRelationship
{
    public class GetCustomersOutput : FacadeResponseBase
    {
        public List<Customer> Customers { get; set; }
    }
}
