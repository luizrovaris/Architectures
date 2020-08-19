using CustomerManager.Facade.Exchange.Customer;
using System.Threading.Tasks;

namespace CustomerManager.Facade.Orchestration.Customer
{
    public interface IFacadeOrchestratorCustomer
    {
        Task<GetCustomerByIdOutput> GetCustomerById(GetCustomerByIdInput input);
    }
}
