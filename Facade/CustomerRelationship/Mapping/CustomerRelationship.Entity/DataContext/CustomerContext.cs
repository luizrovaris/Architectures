using CustomerRelationship.Model.Customer;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelationship.Entity.DataContext
{
    public partial class CustomerContext : DbContext
    {
        public virtual DbSet<CustomerModel> Customer { get; set; }

        public CustomerContext(DbContextOptions<CustomerContext> options)
       : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContactModel>(entity =>
            {
                entity.Property(e => e.CellPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTACT_CUSTOMER");
            });

            modelBuilder.Entity<CustomerModel>(entity =>
            {
                entity.Property(e => e.FederalIdentification).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });
        }
    }
}
