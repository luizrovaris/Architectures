using CustomerRelationship.Entity.DataContext;
using CustomerRelationship.Infrastructure.Domain.Domain.Impl;
using CustomerRelationship.Model.Entities;
using System.Threading.Tasks;

namespace CustomerRelationship.Domain.CustomerRelationship.Impl
{
    public class CustomerManager : RepositoryDomainBase<Customer, CustomerRelationshipContext>, ICustomerManager
    {
        public CustomerManager(CustomerRelationshipContext context)
               :base(context)
        {
        }

        public async Task SaveAsync(Customer entity)
        {
            if (entity.Id == 0)
            {
                await base.AddAsync(entity);
            }
            else
            {
                await base.UpdateAsync(entity);
            }
        }
    }
}