using CustomerRelationship.Model.Base;
using System.Collections.Generic;

namespace CustomerRelationship.Model.Customer
{
    public partial class CustomerModel : AuditableBaseEntity
    {
        public CustomerModel()
        {
            this.Contacts = new List<ContactModel>();
        }
        public string Name { get; set; }
        public string FederalIdentification { get; set; }

        public IList<ContactModel> Contacts { get; set; }
    }
}
