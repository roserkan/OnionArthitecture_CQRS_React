using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.EntityConfigurations;

public class CommentEntityConfiguration : BaseEntityConfiguration<Comment>
{
    public override void Configure(EntityTypeBuilder<Comment> builder)
    {
        base.Configure(builder);

        builder.ToTable("comments", TechDbContext.DEFAULT_SCHEMA);

        builder.HasOne(i => i.Product)
            .WithMany(i => i.Comments)
            .HasForeignKey(i => i.ProductId);

        builder.HasOne(i => i.User)
            .WithMany(i => i.Comments)
            .HasForeignKey(i => i.UserId);

    }
}
