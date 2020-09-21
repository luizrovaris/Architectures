﻿using System;

namespace CustomerRelationship.Model.Base
{
    public partial class AuditableBaseEntity : IdentificationBaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
