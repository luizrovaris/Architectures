using CustomerManager.Infrastructure.Model.Exchange;

namespace CustomerManager.Infrastructure.Domain.Domain
{
    public interface IDomainBase
    {
        ResponseBase BaseError { get; set; }
    }
}
