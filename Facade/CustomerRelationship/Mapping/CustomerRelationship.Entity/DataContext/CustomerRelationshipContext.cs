using CustomerRelationship.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelationship.Entity.DataContext
{
    public partial class CustomerRelationshipContext : DbContext
    {
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public CustomerRelationshipContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billing>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
