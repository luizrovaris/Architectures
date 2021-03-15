using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Model.Entities;
using System.Threading.Tasks;

namespace CustomerRelationship.Domain.CustomerRelationship
{
    public interface IBillingManager : IRepositoryDomainBase<Billing>
    {
        Task SaveAsync(Billing entity);
    }
}
