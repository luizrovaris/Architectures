using CustomerRelationship.Entity.DataContext;
using CustomerRelationship.Infrastructure.Domain.Domain.Impl;
using CustomerRelationship.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CustomerRelationship.Domain.CustomerRelationship.Impl
{
    public class BillingManager : RepositoryDomainBase<Billing, CustomerRelationshipContext>, IBillingManager
    {
        public BillingManager(CustomerRelationshipContext context)
               : base(context)
        {
        }

        public async Task SaveAsync(Billing entity)
        {
            entity.Customer = await base._context.Customers
                .FirstOrDefaultAsync(x => x.Id == entity.Customer.Id)
                .ConfigureAwait(false);

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
