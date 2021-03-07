using CustomerRelationship.Entity.DataContext;
using CustomerRelationship.Infrastructure.Domain.Domain.Impl;
using CustomerRelationship.Model.Entities;

namespace CustomerRelationship.Domain.CustomerRelationship.Impl
{
    public class BillingManager : RepositoryDomainBase<Billing, CustomerRelationshipContext>, IBillingManager
    {
        public BillingManager(CustomerRelationshipContext context)
               : base(context)
        {
        }
    }
}
