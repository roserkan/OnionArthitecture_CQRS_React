using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.EntityConfigurations;

public class ProductEntityConfiguration : BaseEntityConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);

        builder.ToTable("products", TechDbContext.DEFAULT_SCHEMA);

        builder.HasOne(i => i.Category)
            .WithMany(i => i.Products)
            .HasForeignKey(i => i.CategoryId);

    }
}
