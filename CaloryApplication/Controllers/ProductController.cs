using CaloryApplication.Models;
using CaloryApplication.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace CaloryApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("/get/product")]
        public ActionResult<List<Product>> GetAllProducts() 
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpPost("/post/product")] 
        public ActionResult Post(ProductViewModel prod)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _productRepository.AddProduct(new Product()
            {
                Name = prod.Name,
                Fats = prod.Fats,
                Squirrels = prod.Squirrels,
                CaloriesPer100gr = prod.CaloriesPer100gr,
                Carbohydrates = prod.Carbohydrates,
            });

            return Ok();
        }

        [HttpGet("/get/product/{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpDelete("/delete/product/{id}")]
        public ActionResult DeleteProductById(int id)
        {
            var product = _productRepository.GetProductById(id);

            if (product == null)
                return NotFound();

            _productRepository.DeleteProduct(product);
            return Ok();
        }
    }
}
