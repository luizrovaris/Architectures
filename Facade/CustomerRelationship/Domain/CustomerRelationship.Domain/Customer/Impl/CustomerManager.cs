using CustomerRelationship.Entity.DataContext;
using CustomerRelationship.Infrastructure.Domain.Domain.Impl;
using CustomerRelationship.Model.Customer;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CustomerRelationship.Domain.Customer.Impl
{
    public class CustomerManager : DomainBase, ICustomerManager
    {
        private readonly CustomerContext dbContext;

        public CustomerManager(CustomerContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<CustomerModel> GetCustomerById(int id)
        {
            CustomerModel item = await this.dbContext.Customer?
                .Include(x => x.Contacts)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            return item;
        }
    }
}
