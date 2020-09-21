using CustomerRelationship.Infrastructure.Model.Exchange;

namespace CustomerRelationship.Infrastructure.Domain.Domain.Impl
{
    /// <summary>
    /// Used as domain base
    /// </summary>
    public class DomainBase : IDomainBase
    {
        public ResponseBase BaseError { get; set; }

        public DomainBase() => this.BaseError = new ResponseBase();
    }
}
