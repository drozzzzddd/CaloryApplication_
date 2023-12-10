using CaloryApplication.Models;

namespace CaloryApplication.Repositories
{
    public interface IMealRepository
    {
        List<Meal> GetAllMeals();
        Meal? GetMealById(int id);
        bool AddMeal(Meal meal);
        bool DeleteMeal(Meal meal);

    }
}