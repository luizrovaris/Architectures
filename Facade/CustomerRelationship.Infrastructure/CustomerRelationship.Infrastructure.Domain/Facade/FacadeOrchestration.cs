using CustomerRelationship.Infrastructure.Domain.Domain;
using CustomerRelationship.Infrastructure.Model.Exchange;
using System.Threading.Tasks;

namespace CustomerRelationship.Infrastructure.Domain.Facade
{
    /// <summary>
    /// Used as façade orchestration base
    /// </summary>
    public abstract class FacadeOrchestration<Tinput, Toutput>
        where Tinput : FacadeRequestBase
        where Toutput : FacadeResponseBase
    {
        public abstract Task<Toutput> Execute(IDomainBase domain, Tinput input, Toutput output);
    }
}
