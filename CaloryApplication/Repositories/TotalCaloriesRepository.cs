using CaloryApplication.ProductDbContext;
using CaloryApplication.Models;
using CaloryApplication.Repositories;

namespace CaloryApplication.Repositories
{
    public class TotalCaloriesRepository : ITotalCaloriesRepository
    {
        private readonly ProductContext _context;

        public TotalCaloriesRepository(ProductContext context)
        {
            _context = context;
        }

        public List<TotalCalories> GetAllTotalCalories()
        {
            return _context.Calories_table.ToList();
        }

        public TotalCalories GetTotalCaloriesById(int id)
        {
            return _context.Calories_table.FirstOrDefault(c => c.Id == id);
        }

        public bool AddTotalCalories(TotalCalories totalCalories)
        {
            _context.Calories_table.Add(totalCalories);
            _context.SaveChanges();

            return true;
        }

    /*    public void UpdateTotalCalories(TotalCalories totalCalories)
        {
            _context.Calories_table.Update(totalCalories);
            _context.SaveChanges();
        } */

        public bool DeleteTotalCalories(TotalCalories totalCalories)
        {
            _context.Calories_table.Remove(totalCalories);
            _context.SaveChanges();

            return true;
        }
    }
    /*       private TotalCaloriesContext _totalCaloriesContext;

           public TotalCaloriesRepository(TotalCaloriesContext context)
           {
               _totalCaloriesContext = context;
           }

           public bool AddTotalCalories(TotalCalories totalCalories)
           {
               _totalCaloriesContext.Calories.Add(totalCalories);
               _totalCaloriesContext.SaveChanges();

               return true;
           }

           public List<TotalCalories> GetAllTotalCalories()
           {
               return _totalCaloriesContext.Calories.ToList();
           }

           public TotalCalories? GetTotalCaloriesById(int id)
           {
               return _totalCaloriesContext.Calories.Where(t => t.Id == id).FirstOrDefault();
           }

           public bool DeleteTotalCalories(TotalCalories totalCalories)
           {
               _totalCaloriesContext.Remove(totalCalories);
               _totalCaloriesContext.SaveChanges();

               return true;
           }
       } */
}

