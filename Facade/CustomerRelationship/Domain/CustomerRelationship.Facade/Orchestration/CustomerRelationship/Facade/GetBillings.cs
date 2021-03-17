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
    internal class GetBillings : FacadeBase<GetBillingsInput, GetBillingsOutput>
    {
        public override async Task<GetBillingsOutput> Execute(IDomainBase domain, GetBillingsInput input, GetBillingsOutput output)
        {
            IEnumerable<Billing> billings = await ((IBillingManager)domain).GetAllAsync();

            output.Billings = billings.ToList();

            return output;
        }
    }
}
