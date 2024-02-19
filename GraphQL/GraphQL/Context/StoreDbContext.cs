using GraphQL.Context.Entities;
using GraphQL.Services.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Services
{
    public class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
