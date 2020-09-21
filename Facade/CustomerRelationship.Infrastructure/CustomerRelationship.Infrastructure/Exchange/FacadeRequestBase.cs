using System;

namespace CustomerRelationship.Infrastructure.Model.Exchange
{
    /// <summary>
    /// Used as facade request base
    /// </summary>
    public class FacadeRequestBase
    {
        public FacadeRequestBase()
        {
            this.RequestKey = Guid.NewGuid();
        }

        /// <summary>
        /// Key used to identify a transaction (request and response)
        /// </summary>
        public Guid RequestKey { get; set; }
    }
}
