using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship
{
    public interface IFacadeOrchestratorCustomer
    {
        Task<GetCustomersOutput> GetCustomersAsync(GetCustomersInput input);
        Task<SaveCustomerOutput> SaveCustomerAsync(SaveCustomerInput input);
    }
}
