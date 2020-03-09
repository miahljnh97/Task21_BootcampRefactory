using System;
using Microsoft.EntityFrameworkCore;

namespace ProductService.Model
{
    public class PSContext : DbContext
    {
        public PSContext(DbContextOptions<PSContext> opt): base(opt) { }

        public DbSet<Products> products { get; set; }
    }
}
