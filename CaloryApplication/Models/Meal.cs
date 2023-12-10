using Microsoft.AspNetCore.SignalR;
using CaloryApplication.Models;

namespace CaloryApplication.Models
{
    public class Meal
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

     //   public int ProductId { get; set; }

        public Product Product { get; set; }

        public double Quantity { get; set; }

        public double ConsumeCalories => Quantity * Product.CaloriesPer100gr / 100.0;

        public double ConsumeSquirrels => Quantity * Product.Squirrels / 100.0;

        public double ConsumeFats => Quantity * Product.Fats / 100.0;

        public double ConsumeCarbohydrates => Quantity * Product.Carbohydrates / 100.0;
    }


    public class MealViewModel
    {
        public DateTime DateTime { get; set; }

        public int ProductId { get; set; }

        public double Quantity { get; set; }

        public double ConsumeCalories { get; set; }

        public double ConsumeSquirrels { get; set; }

        public double ConsumeFats { get; set; }

        public double ConsumeCarbohydrates { get; set; }
    }
}
