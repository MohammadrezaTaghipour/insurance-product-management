using insurance.product.management.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace insurance.product.management.app.Infrastructure.Data;

public class ProductConfigurations : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("ProductCategories");

        builder.HasIndex(p => p.Id).IsUnique();
        builder.Property(b => b.Id).ValueGeneratedNever();

        builder.Property(b => b.Name).IsRequired();
        builder.Property(b => b.ProductCategoryId).IsRequired();
    }
}