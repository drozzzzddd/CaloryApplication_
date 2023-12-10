using CaloryApplication.ProductDbContext;
using System.Linq;

namespace CaloryApplication.Models
{
	public class TotalCalories
	{
		public int Id { get; set; }
		
		public DateTime Date { get; set; }

        public double TotalConsumedCalories { get; set; }// => Meal.Sum(meal => meal.ConsumedCalories);

        public double TotalConsumeSquirrels { get; set; } //=> Meal.Sum(meal => meal.ConsumedSquirrels);

        public double TotalConsumedCarbohydrates { get; set; }// => Meal.Sum(meal => meal.ConsumedCarbohydrates);

        public double TotalConsumedFats { get; set; }//=> Meal.Sum(meal => meal.ConsumedFats);

    }

    public class TotalCaloriesViewModel
    {
        public DateTime Date { get; set; }

       public double TotalConsumedCalories { get; set; }

        public double TotalConsumedCarbohydrates { get; set; }

        public double TotalConsumedFats { get; set; }
    }
}
