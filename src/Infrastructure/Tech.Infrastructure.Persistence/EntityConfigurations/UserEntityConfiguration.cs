using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.EntityConfigurations;

public class UserEntityConfiguration : BaseEntityConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("users", TechDbContext.DEFAULT_SCHEMA);


        builder.HasOne(i => i.Address)
          .WithOne(i => i.User)
          .HasForeignKey<User>(i => i.AddressId);

    }
}
