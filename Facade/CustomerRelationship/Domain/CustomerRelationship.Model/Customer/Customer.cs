﻿using CustomerRelationship.Model.Base;
using System.Collections.Generic;

namespace CustomerRelationship.Model.Customer
{
    public partial class Customer : AuditableBaseEntity
    {
        public Customer()
        {
            this.Contacts = new List<Contact>();
        }
        public string Name { get; set; }
        public string FederalIdentification { get; set; }

        public IList<Contact> Contacts { get; set; }
    }
}