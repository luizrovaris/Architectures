using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship.Facade
{
    internal class DeleteCustomer : FacadeBase<DeleteCustomerInput, DeleteCustomerOutput>
    {
        public override async Task<DeleteCustomerOutput> Execute(IDomainBase domain, DeleteCustomerInput input, DeleteCustomerOutput output)
        {
            await ((ICustomerManager)domain).DeleteAsync(input.CustomerId);
            return output;
        }
    }
}
