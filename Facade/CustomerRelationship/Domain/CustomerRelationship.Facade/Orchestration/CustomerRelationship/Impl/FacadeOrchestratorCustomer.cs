using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Facade.Exchange.CustomerRelationship.Validator;
using CustomerRelationship.Facade.Orchestration.CustomerRelationship.Facade;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.CustomerRelationship.Impl
{
    public class FacadeOrchestratorCustomer : IFacadeOrchestratorCustomer
    {
        private readonly ICustomerManager _customerManager;

        public FacadeOrchestratorCustomer(ICustomerManager customerManager)
        {
            this._customerManager = customerManager;
        }

        public async Task<GetCustomersOutput> GetCustomersAsync(GetCustomersInput input)
        {
            GetCustomersOutput output = await Orchestrator.Execute<GetCustomers, GetCustomersInput, GetCustomersOutput, GetCustomersValidator>(_customerManager, input);
            return output;
        }
    }
}
