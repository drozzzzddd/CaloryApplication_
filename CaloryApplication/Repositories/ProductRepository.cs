using CaloryApplication.ProductDbContext;
using CaloryApplication.Models;
//using ProductContext.DbContext;
namespace CaloryApplication.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _productContext;
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

    
}
