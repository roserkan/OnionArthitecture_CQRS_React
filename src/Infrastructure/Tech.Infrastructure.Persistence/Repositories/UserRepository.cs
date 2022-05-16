using Tech.Application.Interfaces.Repositories;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(TechDbContext dbContext) : base(dbContext)
    {
    }
}
