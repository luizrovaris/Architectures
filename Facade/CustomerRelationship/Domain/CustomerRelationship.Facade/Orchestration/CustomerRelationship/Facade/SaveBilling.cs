using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship.Facade
{
    internal class SaveBilling : FacadeBase<SaveBillingInput, SaveBillingOutput>
    {
        public override async Task<SaveBillingOutput> Execute(IDomainBase domain, SaveBillingInput input, SaveBillingOutput output)
        {
            await ((IBillingManager)domain).SaveAsync(input.Billing);

            return output;
        }
    }
}
