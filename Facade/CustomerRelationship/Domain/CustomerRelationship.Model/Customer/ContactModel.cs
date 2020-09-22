using CustomerRelationship.Model.Base;

namespace CustomerRelationship.Model.Customer
{
    public partial class ContactModel : AuditableBaseEntity
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }

        public CustomerModel Customer { get; set; }
    }
}
