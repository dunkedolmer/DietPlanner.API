using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DietplannerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // Sample data
        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.99M },
            new Product { Id = 2, Name = "Product B", Price = 20.99M },
            new Product { Id = 3, Name = "Product C", Price = 30.99M }
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(Products);
        }
    }

    // Sample model class
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
