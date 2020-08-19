using CustomerManager.Infrastructure.Model.Exchange;

namespace CustomerManager.Infrastructure.Domain.Domain.Impl
{
    public class DomainBase : IDomainBase
    {
        public ResponseBase BaseError { get; set; }

        public DomainBase() => this.BaseError = new ResponseBase();
    }
}
