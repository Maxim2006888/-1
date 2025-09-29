using ECommerceApp.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceApp.Data.Repositories
{
    public class ProductRepository
    {
        private readonly List<Product> _products = new();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
