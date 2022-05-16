using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.EntityConfigurations;

public class OrderEntityConfiguration : BaseEntityConfiguration<Order>
{
    public override void Configure(EntityTypeBuilder<Order> builder)
    {
        base.Configure(builder);

        builder.ToTable("orders", TechDbContext.DEFAULT_SCHEMA);

        builder.HasOne(i => i.Product)
           .WithMany(i => i.Orders)
           .HasForeignKey(i => i.ProductId);

        builder.HasOne(i => i.User)
            .WithMany(i => i.Orders)
            .HasForeignKey(i => i.UserId);
    }
}
