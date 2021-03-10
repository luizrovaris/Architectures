using CustomerRelationship.Infrastructure.Model.BaseModel;

namespace CustomerRelationship.Model.Entities
{
    public partial class Contact : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
