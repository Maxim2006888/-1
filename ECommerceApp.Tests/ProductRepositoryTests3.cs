using Xunit;
using ECommerceApp.Core.Models;
using ECommerceApp.Data.Repositories;

namespace ECommerceApp.Tests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void AddProduct_ShouldIncreaseCount()
        {
            // Arrange
            var repo = new ProductRepository();
            var product = new Product(1, "Laptop", 50000);

            // Act
            repo.AddProduct(product);

            // Assert
            var products = repo.GetAllProducts();
            Xunit.Assert.Single(products);
            Xunit.Assert.Equal("Laptop", products[0].Name);
        }

        [Fact]
        public void GetById_ShouldReturnCorrectProduct()
        {
            // Arrange
            var repo = new ProductRepository();
            var p1 = new Product(1, "Laptop", 50000);
            var p2 = new Product(2, "Mouse", 1000);

            repo.AddProduct(p1);
            repo.AddProduct(p2);

            // Act
            var result = repo.GetById(2);

            // Assert
            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal("Mouse", result!.Name);
        }
    }
}
