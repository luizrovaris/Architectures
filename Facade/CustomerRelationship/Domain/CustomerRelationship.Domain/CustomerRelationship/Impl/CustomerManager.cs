using CustomerRelationship.Entity.DataContext;
using CustomerRelationship.Infrastructure.Domain.Domain.Impl;
using CustomerRelationship.Model.Entities;

namespace CustomerRelationship.Domain.CustomerRelationship.Impl
{
    public class CustomerManager : RepositoryDomainBase<Customer, CustomerRelationshipContext>, ICustomerManager
    {
        public CustomerManager(CustomerRelationshipContext context)
               :base(context)
        {
        }
    }
}