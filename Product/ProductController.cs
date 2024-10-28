using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DietPlannerAPI.Product
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        // Inject the ProductsService via constructor dependency injection
        public ProductsController(ProductService productsService)
        {
            _productService = productsService;
        }

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        // Add more endpoints like POST, PUT, DELETE as needed
    }
}