using insurance.product.management.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace insurance.product.management.app.Infrastructure.Data;

public class ProductCategoryConfigurations : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategories");

        builder.HasIndex(p => p.Id).IsUnique();
        builder.Property(b => b.Id).ValueGeneratedNever();

        builder.Property(b => b.Name).IsRequired();
        builder.Property(b => b.ParentId).IsRequired(false);
    }
}