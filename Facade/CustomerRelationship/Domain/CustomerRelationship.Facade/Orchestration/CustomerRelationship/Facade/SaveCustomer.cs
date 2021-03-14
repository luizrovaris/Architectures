using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship.Facade
{
    internal class SaveCustomer : FacadeBase<SaveCustomerInput, SaveCustomerOutput>
    {
        public override async Task<SaveCustomerOutput> Execute(IDomainBase domain, SaveCustomerInput input, SaveCustomerOutput output)
        {
            await ((ICustomerManager)domain).SaveAsync(input.Customer);

            return output;
        }
    }
}
