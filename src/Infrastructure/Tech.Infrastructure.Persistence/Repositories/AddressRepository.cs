using Tech.Application.Interfaces.Repositories;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.Repositories;

public class AddressRepository : GenericRepository<Address>, IAddressRepository
{
    public AddressRepository(TechDbContext dbContext) : base(dbContext)
    {
    }
}
