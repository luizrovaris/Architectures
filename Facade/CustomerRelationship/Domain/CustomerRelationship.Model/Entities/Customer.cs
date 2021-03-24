using CustomerRelationship.Infrastructure.Model.BaseModel;
using System.Collections.Generic;

namespace CustomerRelationship.Model.Entities
{
    public partial class Customer : AuditableBaseEntity
    {
        public Customer()
        {
            this.Contacts = new List<Contact>();
            //this.Billings = new List<Billing>();
        }

        public string Name { get; set; }
        public string FederalIdentification { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual IList<Contact> Contacts { get; set; }
        //public virtual IList<Billing> Billings { get; set; }
    }
}
