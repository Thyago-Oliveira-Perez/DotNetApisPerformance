using Microsoft.EntityFrameworkCore;
using Rest.Context;
using Rest.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("default");

builder.Services.AddPooledDbContextFactory<StoreDbContext>(db => db.UseSqlite(connectionString));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ProductService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

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
