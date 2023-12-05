namespace CaloryApplication.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public double Fats { get; set; }

        public double Squirrels { get; set; } 

        public double Carbohydrates { get; set; } 

        public int CaloriesPer100gr { get; set; } 
    }

    public class ProductViewModel
    {
        public string Name { get; set; }

        public double Fats { get; set; } 

        public double Squirrels { get; set; } 
        public int CaloriesPer100gr { get; set; } 

        public double Carbohydrates { get; set; } 
    }
}
