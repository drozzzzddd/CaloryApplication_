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

        public ProductController(IProductRepository repository)
        {
            _productRepository = repository;
        }

        [HttpGet("/get")]

        public ActionResult<List<Product>> Get()
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("/post")]

        public ActionResult Post(ProductViewModel prod)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _productRepository.AddProduct(new Product()
            {
                Name = prod.Name,
                CaloryInGr = prod.CaloryInGr,
                Portion = prod.Portion,
                Squirrels = prod.Squirrels,
                Carboh = prod.Carboh,
                Fats = prod.Fats,
            });
            return Ok();
        }

        [HttpGet("/get/{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpDelete("/delete/{id}")]

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
