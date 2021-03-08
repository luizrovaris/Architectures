using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Infrastructure.Domain.Facade;
using CustomerRelationship.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship.Facade
{
    public class GetCustomers : FacadeBase<GetCustomersInput, GetCustomersOutput>
    {
        public override async Task<GetCustomersOutput> Execute(IDomainBase domain, GetCustomersInput input, GetCustomersOutput output)
        {
            IEnumerable<Customer> customers = await ((ICustomerManager)domain).GetAllAsync();

            output.Customers = customers.ToList();

            return output;
        }
    }
}
