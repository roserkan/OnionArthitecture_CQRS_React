using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.EntityConfigurations;

public class CategoryEntityConfiguration : BaseEntityConfiguration<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        base.Configure(builder);

        builder.ToTable("categories", TechDbContext.DEFAULT_SCHEMA);
    }
}
