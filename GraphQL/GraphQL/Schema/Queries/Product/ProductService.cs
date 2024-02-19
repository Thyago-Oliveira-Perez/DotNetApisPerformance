using GraphQL.Services;
using Microsoft.EntityFrameworkCore;
using ProductEntity = GraphQL.Services.Entities.Product;

namespace GraphQL.Schema.Queries.Product
{
    public class ProductService(IDbContextFactory<StoreDbContext> dbContext)
    {
        private readonly StoreDbContext context = dbContext.CreateDbContext();

        public Task<IQueryable<ProductEntity>> Get1000()
        {
            return Task.FromResult(context.Products.OrderBy(p => p.CreatedAt).Take(1000));
        }
    }
}
