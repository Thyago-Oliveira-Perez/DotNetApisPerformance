using GraphQL.Context;
using GraphQL.Schema.Queries.Product;
using GraphQL.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("default");

builder.Services.AddPooledDbContextFactory<StoreDbContext>(db => db.UseSqlite(connectionString));

builder.Services.AddScoped<ProductService>();

builder.Services.AddGraphQLServer().AddQueryType<ProductQueries>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGraphQL();

using (IServiceScope scope = app.Services.CreateScope())
{
    var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<StoreDbContext>>();

    using (var context = contextFactory.CreateDbContext())
    {
        context.Database.Migrate();
        Seed.SeedData(context);
    }
}

app.Run();
