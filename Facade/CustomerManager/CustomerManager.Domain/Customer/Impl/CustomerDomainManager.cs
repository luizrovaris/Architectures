using CustomerManager.Entity.DataContext;
using CustomerManager.Infrastructure.Domain.Domain.Impl;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CustomerManager.Domain.Customer.Impl
{
    public class CustomerDomainManager : DomainBase, ICustomerDomainManager
    {
        private readonly CustomerContext dbContext;

        public CustomerDomainManager(CustomerContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Model.Customer.Customer> GetCustomerById(int id)
        {
            Model.Customer.Customer item = await this.dbContext.Customer?
                .Include(x => x.Contacts)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            return item;
        }
    }
}
