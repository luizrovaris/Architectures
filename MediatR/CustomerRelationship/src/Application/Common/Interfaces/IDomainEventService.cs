using CustomerRelationship.Domain.Common;
using System.Threading.Tasks;

namespace CustomerRelationship.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
