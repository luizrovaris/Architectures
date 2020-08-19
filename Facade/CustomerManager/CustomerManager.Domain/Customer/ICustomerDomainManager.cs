using CustomerManager.Infrastructure.Domain.Domain;
using System.Threading.Tasks;

namespace CustomerManager.Domain.Customer
{
    public interface ICustomerDomainManager : IDomainBase
    {
        Task<Model.Customer.Customer> GetCustomerById(int id);
    }
}
