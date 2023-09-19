using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Store.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }

        public class AppliContext:DbContext

    {
        public AppliContext(DbContextOptions<AppliContext> op):base(op)
        {
                
        }

        public DbSet<Category>? TblCategory { get; set; }
        public DbSet<Product>? TblProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
