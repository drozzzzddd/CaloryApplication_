using CaloryApplication.ProductDbContext;
using CaloryApplication.Models;
using CaloryApplication.Repositories;
using Microsoft.EntityFrameworkCore;


namespace CaloryApplication.Repositories
{
    public class MealRepository : IMealRepository {

        private ProductContext _context;

        public MealRepository(ProductContext context)
        {
            _context = context;
        }

        public List<Meal> GetAllMeals()
        {
            return _context.Meals.ToList();
        }

        public Meal GetMealById(int id)
        {
            return _context.Meals.FirstOrDefault(m => m.Id == id);
        }

        public bool AddMeal(Meal meal)
        {
            _context.Meals.Add(meal);
            _context.SaveChanges();

            return true;
        }

        public bool DeleteMeal(Meal meal)
        {
            _context.Meals.Remove(meal);
            _context.SaveChanges();

            return true;
        }
    }

    