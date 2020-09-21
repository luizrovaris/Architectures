using CustomerRelationship.Infrastructure.Model.Exchange;

namespace CustomerRelationship.Infrastructure.Domain.Domain
{
    /// <summary>
    /// Used as domain base interface
    /// </summary>
    public interface IDomainBase
    {
        ResponseBase BaseError { get; set; }
    }
}
