using CustomerRelationship.Model.Base;
using System.Collections.Generic;

namespace CustomerRelationship.Model.Entities
{
    public partial class Customer : AuditableBaseEntity
    {
        public Customer()
        {
            this.Contacts = new List<Contact>();
            this.Billings = new List<Billing>();
        }

        public string Name { get; set; }
        public string FederalIdentification { get; set; }
        public string Address { get; set; }

        public IList<Contact> Contacts { get; set; }
        public IList<Billing> Billings { get; set; }
    }
}
