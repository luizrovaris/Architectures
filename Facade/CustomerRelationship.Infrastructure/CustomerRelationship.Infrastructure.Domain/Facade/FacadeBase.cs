using CustomerRelationship.Infrastructure.Model.Exchange;

namespace CustomerRelationship.Infrastructure.Domain.Facade
{
    /// <summary>
    /// Used as base class to façade implementation
    /// </summary>
    public abstract class FacadeBase<Tinput, Toutput> : FacadeOrchestration<Tinput, Toutput>
            where Tinput : FacadeRequestBase
            where Toutput : FacadeResponseBase
    {
        public FacadeBase()
        {
            //TODO: Criar autenticação
            //this.Auth = GetAuth();
        }

        /// <summary>
        /// Authentication data
        /// </summary>
        //public Auth auth { get; set; }
    }
}
