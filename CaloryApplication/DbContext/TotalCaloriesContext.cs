//using CaloryApplication.DbContext;
using CaloryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CaloryApplication.TotalCaloriesDbContext
{
    public class TotalCaloriesContext : DbContext
    {
        public TotalCaloriesContext(DbContextOptions<TotalCaloriesContext> options) : base(options) { }

        public DbSet<TotalCalories> Calories { get; set; }
    }
} 
