using CaloryApplication.TotalCaloriesDbContext;
using CaloryApplication.Models;
using CaloryApplication.Repositories;

namespace CaloryApplication.Repositories
{
    public class TotalCaloriesRepository : ITotalCaloriesRepository
    {
        private TotalCaloriesContext _totalCaloriesContext;

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
    }
}

