using System;
using Microsoft.EntityFrameworkCore;

namespace MerchantService.Model
{
    public class MSContext : DbContext
    {
        public MSContext(DbContextOptions<MSContext> opt): base(opt) { }
        
        public DbSet<Merchant> merchants { get; set; }
    }
}
