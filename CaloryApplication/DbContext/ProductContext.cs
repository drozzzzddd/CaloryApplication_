using CaloryApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace CaloryApplication.ProductDbContext
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
