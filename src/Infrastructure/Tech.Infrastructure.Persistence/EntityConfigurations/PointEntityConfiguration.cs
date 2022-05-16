using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.EntityConfigurations;

public class PointEntityConfiguration : BaseEntityConfiguration<Point>
{
    public override void Configure(EntityTypeBuilder<Point> builder)
    {
        base.Configure(builder);

        builder.ToTable("points", TechDbContext.DEFAULT_SCHEMA);

        builder.HasOne(i => i.Product)
            .WithOne(i => i.Point)
            .HasForeignKey<Product>(i => i.PointId);


    }
}
