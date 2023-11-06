namespace CaloryApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CaloryInGr { get; set; } //количество калорий в 100 граммах

        public int Portion { get; set; } //граммы порции

        public double Squirrels { get; set; } // белки

        public double Fats { get; set; } //жиры

        public double Carboh { get; set; } //углеводы
    }

    public class ProductViewModel
    {
        public string Name { get; set; } = string.Empty;

        public int CaloryInGr { get; set; } //количество калорий в 100 граммах

        public int Portion { get; set; } //граммы порции

        public double Squirrels { get; set; } // белки

        public double Fats { get; set; } //жиры

        public double Carboh { get; set; } //углеводы
    }
}
