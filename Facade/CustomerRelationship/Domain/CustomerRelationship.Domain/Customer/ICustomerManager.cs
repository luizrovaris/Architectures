using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Model.Customer;
using System.Threading.Tasks;

namespace CustomerRelationship.Domain.Customer
{
    public interface ICustomerManager : IDomainBase
    {
        Task<CustomerModel> GetCustomerById(int id);
    }
}
