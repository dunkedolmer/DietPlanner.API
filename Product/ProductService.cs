using System.Collections.Generic;

namespace DietPlannerAPI.Product
{
    public class ProductService
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.99M },
            new Product { Id = 2, Name = "Product B", Price = 20.99M },
            new Product { Id = 3, Name = "Product C", Price = 30.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return Products;
        }

        public string Test()
        {
            return "This is a test from the ProductService class";
        }
    }
}