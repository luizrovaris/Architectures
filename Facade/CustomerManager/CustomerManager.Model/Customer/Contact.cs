using CustomerManager.Model.Base;

namespace CustomerManager.Model.Customer
{
    public partial class Contact : AuditableBaseEntity
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }

        public Customer Customer { get; set; }
    }
}
