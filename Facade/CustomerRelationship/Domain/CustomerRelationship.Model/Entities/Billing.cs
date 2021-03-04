using CustomerRelationship.Model.Base;
using System;

namespace CustomerRelationship.Model.Entities
{
    public class Billing : IdentificationBaseEntity
    {
        public string InvoiceNumber { get; set; }
        public DateTime EmissionDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal ReceiptValue { get; set; }
        public decimal IncreasedValue { get; set; }
        public decimal DiscountValue { get; set; }

        public Customer Customer { get; set; }
    }
}
