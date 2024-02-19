using Microsoft.EntityFrameworkCore;
using Rest.Context.Entities;

namespace Rest.Context
{
    public class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
