using GraphQL.Services;
using GraphQL.Services.Entities;

namespace GraphQL.Context
{
    public class Seed
    {
        public static void SeedData(StoreDbContext context)
        {
            if (!context.Products.Any())
            {
                var products = GenerateProducts(2000);
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
        private static List<Product> GenerateProducts(int numberOfProducts)
        {
            var products = new List<Product>();
            for (int i = 1; i <= numberOfProducts; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = "Default description",
                    Price = new Random().Next(150, 1000),
                    CreatedAt = DateTime.Now
                });
            }
            return products;
        }
    }
}
