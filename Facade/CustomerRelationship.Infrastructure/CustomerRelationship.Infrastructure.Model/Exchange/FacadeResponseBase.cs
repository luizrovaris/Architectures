using System;

namespace CustomerRelationship.Infrastructure.Model.Exchange
{
    /// <summary>
    /// Used as facade response base
    /// </summary>
    public class FacadeResponseBase : ResponseBase
    {
        /// <summary>
        /// Key used to identify a transaction (request and response)
        /// </summary>
        public Guid RequestKey { get; set; }
    }
}
