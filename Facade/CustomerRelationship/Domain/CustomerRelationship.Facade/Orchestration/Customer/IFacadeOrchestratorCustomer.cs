using CustomerRelationship.Facade.Exchange.Customer;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.Customer
{
    public interface IFacadeOrchestratorCustomer
    {
        Task<GetCustomerByIdOutput> GetCustomerById(GetCustomerByIdInput input);
    }
}
