using System;

namespace CustomerRelationship.Infrastructure.Model.BaseModel
{
    /// <summary>
    /// Used as auditable base class to entities
    /// </summary>
    public class AuditableBaseEntity : IdentificationBaseEntity
    {
        public DateTime CreatedOn { get; set; }
    }
}
