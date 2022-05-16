using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.EntityConfigurations;

public class AddressEntityConfiguration : BaseEntityConfiguration<Address>
{
    public override void Configure(EntityTypeBuilder<Address> builder)
    {
        base.Configure(builder);

        builder.ToTable("addresses", TechDbContext.DEFAULT_SCHEMA);
    }
}
