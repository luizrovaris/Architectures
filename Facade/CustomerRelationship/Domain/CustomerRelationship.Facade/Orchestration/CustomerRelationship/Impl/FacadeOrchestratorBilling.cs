using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship.Validator;
using CustomerRelationship.Facade.Orchestration.CustomerRelationship.Facade;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship.Impl
{
    public class FacadeOrchestratorBilling : IFacadeOrchestratorBilling
    {
        private readonly IBillingManager _billingManager;

        public FacadeOrchestratorBilling(IBillingManager billingManager)
        {
            this._billingManager = billingManager;
        }

        public async Task<SaveBillingOutput> SaveBillingAsync(SaveBillingInput input)
        {
            SaveBillingOutput output = await Orchestrator.Execute<SaveBilling, SaveBillingInput, SaveBillingOutput, SaveBillingValidator>(_billingManager, input);
            return output;
        }

        public async Task<GetBillingsOutput> GetBillingsAsync(GetBillingsInput input)
        {
            GetBillingsOutput output = await Orchestrator.Execute<GetBillings, GetBillingsInput, GetBillingsOutput, GetBillingsValidator>(_billingManager, input);
            return output;
        }
    }
}
