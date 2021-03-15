using CustomerRelationship.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelationship.Entity.DataContext
{
    public partial class CustomerRelationshipContext : DbContext
    {
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public CustomerRelationshipContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(builder =>
            {
                builder.HasKey(p => p.Id);

                builder.Property(p => p.FederalIdentification)
                    .IsRequired()
                    .HasMaxLength(25);

                builder.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                builder.HasOne(p => p.Address);

                builder.HasMany(p => p.Billings)
                    .WithOne(p => p.Customer)
                    .HasForeignKey(p => p.CustomerId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.NoAction);

                builder.HasMany(p => p.Contacts);
                    //.WithOne(p => p.Customer)
                    //.HasForeignKey(p => p.CustomerId)
                    //.IsRequired(false)
                    //.OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Billing>(builder =>
            {
                builder.HasKey(p => p.Id);

                builder.Property(p => p.EmissionDate)
                    .IsRequired();

                builder.Property(p => p.DueDate)
                    .IsRequired();

                builder.Property(p => p.PaymentDate)
                    .IsRequired(false);

                builder.Property(p => p.Description)
                    .IsRequired(false)
                    .HasMaxLength(250);

                builder.Property(p => p.Value)
                    .IsRequired()
                    .HasColumnType("decimal(19,2)");

                builder.Property(p => p.ReceiptValue)
                    .IsRequired(false)
                    .HasColumnType("decimal(19,2)");

                builder.Property(p => p.IncreasedValue)
                    .IsRequired(false)
                    .HasColumnType("decimal(19,2)");

                builder.Property(p => p.DiscountValue)
                    .IsRequired(false)
                    .HasColumnType("decimal(19,2)");
            });

            modelBuilder.Entity<Contact>(builder =>
            {
                builder.HasKey(p => p.Id);

                builder.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                builder.Property(p => p.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                builder.Property(p => p.Phone)
                    .IsRequired(false)
                    .HasMaxLength(18);

                builder.Property(p => p.CellPhone)
                    .IsRequired(false)
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<Address>(builder =>
            {
                builder.HasKey(p => p.Id);

                builder.Property(p => p.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                builder.Property(p => p.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(250);

                builder.Property(p => p.AddressLine2)
                    .IsRequired(false)
                    .HasMaxLength(250);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
