using GraphQL.Context.Entities;
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
                AddClient(context);
                var products = AddProducts(context);
                AddTransaction(context, products);
            }
        }

        private static List<Product> AddProducts(StoreDbContext context)
        {
            var products = GenerateProducts(2000);
            context.Products.AddRange(products);
            context.SaveChanges();
            return products;
        }

        private static void AddClient(StoreDbContext context)
        {
            context.Clients.Add(new Client()
            {
                Id = 1,
                Name = "The Client"
            });

            context.SaveChanges();
        }

        public static void AddTransaction(StoreDbContext context, List<Product> products)
        {
            var transactions = GenerateTransactions(products);
            context.Transactions.AddRange(transactions);
            context.SaveChanges();
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

        private static List<Transaction> GenerateTransactions(List<Product> products)
        {
            var transactions = new List<Transaction>();

            foreach (var product in products)
            {
                for (int i = 1; i <= 10; i++)
                {
                    transactions.Add(new Transaction
                    {
                        Id = Guid.NewGuid(),
                        ProductId = product.Id,
                        ClientId = 1,
                        Date = DateTime.Now,
                        CreatedAt = DateTime.Now
                    });
                }
            }

            return transactions;
        }
    }
}
