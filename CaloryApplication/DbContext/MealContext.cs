using CaloryApplication.Models;
using Microsoft.EntityFrameworkCore;


namespace CaloryApplication.MealDbContext
{
    public class MealContext : DbContext
    {
        public MealContext(DbContextOptions<MealContext> options) : base(options) { }   

        public DbSet<Meal> Meals { get; set; }
    }
}