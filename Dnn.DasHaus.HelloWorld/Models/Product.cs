using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;
using System;
using System.Collections.Generic;
using System.Web.Caching;

namespace DasHaus.Dnn.Dnn.DasHaus.HelloWorld.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }

    }
    public class TestProductData
    {
        public List<Product> GetTestProducts()
        {
            var products = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                Name = "Sample Product 1",
                Description = "This is a sample product description.",
                Price = 19.99m,
                Category = "Electronics",
                Brand = "Sample Brand"
            },
            new Product
            {
                ProductId = 2,
                Name = "Sample Product 2",
                Description = "Another sample product description.",
                Price = 29.99m,
                Category = "Clothing",
                Brand = "Another Brand"
            },
        };

            return products;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestProductData testData = new TestProductData();
            List<Product> testProducts = testData.GetTestProducts();

            // Print out test product details
            Console.WriteLine("Test Products:");
            foreach (var product in testProducts)
            {
                Console.WriteLine($"Product ID: {product.ProductId}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine($"Price: {product.Price:C}");
                Console.WriteLine($"Category: {product.Category}");
                Console.WriteLine($"Brand: {product.Brand}");
                Console.WriteLine();
            }
        }
    }
}
