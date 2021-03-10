using CustomerRelationship.Infrastructure.Model.BaseModel;

namespace CustomerRelationship.Model.Entities
{
    public class Address : IdentificationBaseEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
    }
}
