using CustomerRelationship.Domain.Customer;
using CustomerRelationship.Facade.Exchange.Customer;
using CustomerRelationship.Facade.Exchange.Customer.Validator;
using CustomerRelationship.Facade.Orchestration.Customer.Facade;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.Customer.Impl
{
    public class FacadeOrchestratorCustomer : IFacadeOrchestratorCustomer
    {
        private readonly ICustomerManager domain;

        public FacadeOrchestratorCustomer(ICustomerManager domain)
        {
            this.domain = domain;
        }

        public async Task<GetCustomerByIdOutput> GetCustomerById(GetCustomerByIdInput input)
        {
            GetCustomerByIdOutput output = await Orchestrator.Execute<GetCustomerById, GetCustomerByIdInput, GetCustomerByIdOutput, GetCustomerByIdInputValidator>(this.domain, input);

            return output;
        }
    }
}
