using System;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Model
{
    public class CSContext : DbContext
    {
        public CSContext(DbContextOptions<CSContext> opt) : base(opt) { }

        public DbSet<Customers> customers { get; set; }
        public DbSet<Customers_Payment_Card> customerPayCard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Customers_Payment_Card>()
                .HasOne(x => x.customer)
                .WithMany()
                .HasForeignKey(x => x.customer_id);
        }
    }
}
