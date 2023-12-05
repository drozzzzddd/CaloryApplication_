namespace CaloryApplication.Models
{
	public class TotalCalories
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public double TotalConsumedCalories { get; set; }

	}

    public class TotalCaloriesViewModel
    {
        public DateTime Date { get; set; }

       public double TotalConsumedCalories { get; set; }
    }
}
