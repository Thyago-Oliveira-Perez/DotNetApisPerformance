using Microsoft.EntityFrameworkCore;
using Rest.Context;
using Rest.Context.Entities;

namespace Rest.Services
{
    public class ProductService(IDbContextFactory<StoreDbContext> dbContext)
    {
        private readonly StoreDbContext context = dbContext.CreateDbContext();

        public Task<IQueryable<Product>> GetFirst1000()
        {
            return Task.FromResult(context.Products.OrderBy(p => p.CreatedAt).Take(1000));
        }
    }
}
