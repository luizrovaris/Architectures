using System;

namespace CustomerRelationship.Model.Base
{
    public partial class AuditableBaseEntity : IdentificationBaseEntity
    {
        public DateTime CreatedOn { get; set; }
    }
}
