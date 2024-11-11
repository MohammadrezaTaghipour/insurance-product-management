using Microsoft.EntityFrameworkCore;

namespace insurance.product.management.app.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // public DbSet<User> Users { get; set; }
    // public DbSet<Company> Companies { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductCategoryConfigurations).Assembly);
    }
}