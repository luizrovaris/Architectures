using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Model.Entities;
using System.Threading.Tasks;

namespace CustomerRelationship.Domain.CustomerRelationship
{
    public interface ICustomerManager : IRepositoryDomainBase<Customer>
    {
        Task SaveAsync(Customer entity);
    }
}
