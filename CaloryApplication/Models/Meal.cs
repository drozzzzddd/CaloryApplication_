namespace CaloryApplication.Models
{
	public class Meal
	{
		public int Id { get; set; }

		public DateTime DateTime { get; set; }

		public int ProductId { get; set; }

		public double Quantity { get; set; }

		public double ConsumeCalories { get; set; }

		public double ConsumeSquirrels { get; set; }

		public double ConsumeFats { get; set; }

		public double ConsumeCarbohydrates { get; set; }
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
