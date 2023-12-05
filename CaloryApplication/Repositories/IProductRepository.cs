using CaloryApplication.Models;

namespace CaloryApplication.Repositories;
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product? GetProductById(int id);
        bool AddProduct(Product product);

        bool DeleteProduct(Product product);
    }