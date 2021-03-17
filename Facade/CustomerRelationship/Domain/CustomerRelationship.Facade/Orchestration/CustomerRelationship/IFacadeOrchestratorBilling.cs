using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship
{
    public interface IFacadeOrchestratorBilling
    {
        Task<SaveBillingOutput> SaveBillingAsync(SaveBillingInput input);
        Task<GetBillingsOutput> GetBillingsAsync(GetBillingsInput input);
    }
}
