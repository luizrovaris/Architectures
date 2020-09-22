using CustomerRelationship.Domain.Customer;
using CustomerRelationship.Facade.Exchange.Customer;
using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Infrastructure.Domain.Facade;
using System.Threading.Tasks;

namespace CustomerRelationship.Facade.Orchestration.Customer.Facade
{
    public class GetCustomerById : FacadeBase<GetCustomerByIdInput, GetCustomerByIdOutput>
    {
        public override async Task<GetCustomerByIdOutput> Execute(IDomainBase domain, GetCustomerByIdInput input, GetCustomerByIdOutput output)
        {
            output.Customer = await ((ICustomerManager)domain).GetCustomerById(input.Id);

            return output;
        }
    }
}
