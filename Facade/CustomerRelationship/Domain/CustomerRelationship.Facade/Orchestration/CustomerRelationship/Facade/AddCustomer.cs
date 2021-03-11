using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship.Facade
{
    public class AddCustomer : FacadeBase<AddCustomerInput, AddCustomerOutput>
    {
        public override async Task<AddCustomerOutput> Execute(IDomainBase domain, AddCustomerInput input, AddCustomerOutput output)
        {
            await ((ICustomerManager)domain).AddAsync(input.Customer);

            return output;
        }
    }
}
