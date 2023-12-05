using CaloryApplication.Models;

namespace CaloryApplication.Repositories
{
    public interface ITotalCaloriesRepository
    {
        List<TotalCalories> GetAllTotalCalories();
        TotalCalories? GetTotalCaloriesById(int id);

        bool AddTotalCalories(TotalCalories totalcal);

        bool DeleteTotalCalories(TotalCalories totalCalories);
    }
}
