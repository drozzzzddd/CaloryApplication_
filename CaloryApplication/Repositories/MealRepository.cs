using CaloryApplication.MealDbContext;
using CaloryApplication.Models;
using CaloryApplication.Repositories;


namespace CaloryApplication.Repositories
{
    public class MealRepository : IMealRepository
    {
        private MealContext _mealContext;

        public MealRepository(MealContext context)
        {
            _mealContext = context;
        }
        
        public bool AddMeal(Meal meal)
        {
            _mealContext.Meals.Add(meal);
            _mealContext.SaveChanges();

            return true;
        }

        public List<Meal> GetAllMeals()
        {
            return _mealContext.Meals.ToList();
        }

        public Meal? GetMealById(int id)
        {
            return _mealContext.Meals.Where (m => m.Id == id).FirstOrDefault();
        }

        public bool DeleteMeal(Meal meal)
        {
            _mealContext.Remove(meal);
            _mealContext.SaveChanges();

            return true;
        }
    }
}





/*private ProductContext _productContext;
public ProductRepository(ProductContext context)
{
    _productContext = context;
}

public bool AddProduct(Product product)
{
    _productContext.Products.Add(product);
    _productContext.SaveChanges();

    return true;
}

public List<Product> GetAllProducts()
{
    return _productContext.Products.ToList();
}

public Product? GetProductById(int id)
{
    return _productContext.Products.Where(e => e.Id == id).FirstOrDefault();
}

public bool DeleteProduct(Product product)
{
    _productContext.Remove(product);
    _productContext.SaveChanges();

    return true;
}
    }
/*

    