using CustomerManager.Domain.Customer;
using CustomerManager.Facade.Exchange.Customer;
using CustomerManager.Facade.Exchange.Customer.Validator;
using CustomerManager.Facade.Orchestration.Customer.Facade;
using CustomerManager.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerManager.Facade.Orchestration.Customer.Impl
{
    public class FacadeOrchestratorCustomer : IFacadeOrchestratorCustomer
    {
        private readonly ICustomerDomainManager domain;

        public FacadeOrchestratorCustomer(ICustomerDomainManager domain)
        {
            this.domain = domain;
        }

        public async Task<GetCustomerByIdOutput> GetCustomerById(GetCustomerByIdInput input)
        {
            GetCustomerByIdOutput output = null;
            output = await Orchestrator.Execute<GetCustomerById, GetCustomerByIdInput, GetCustomerByIdOutput, GetCustomerByIdInputValidator>(this.domain, input);

            return output;
        }
    }
}
