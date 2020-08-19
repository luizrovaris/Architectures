using CustomerManager.Domain.Customer;
using CustomerManager.Facade.Exchange.Customer;
using CustomerManager.Infrastructure.Domain.Domain;
using CustomerManager.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerManager.Facade.Orchestration.Customer.Facade
{
    public class GetCustomerById : FacadeBase<GetCustomerByIdInput, GetCustomerByIdOutput>
    {
        public override async Task<GetCustomerByIdOutput> Execute(IDomainBase domain, GetCustomerByIdInput input, GetCustomerByIdOutput output)
        {
            output.Customer = await ((ICustomerDomainManager)domain).GetCustomerById(input.Id);

            return output;
        }
    }
}
