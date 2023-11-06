using CaloryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CaloryApplication.ProductDbContext
{
    public class ProductContext : DbContext
    {
       // public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public ProductContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=127.0.0.1;user=root;password=bdhs-844_dhvsg;database=CaloryApp;",
                new MySqlServerVersion(new Version(8, 0, 34))
                );
        }
    }
}
