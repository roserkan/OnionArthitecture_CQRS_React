using Tech.Application.Interfaces.Repositories;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(TechDbContext dbContext) : base(dbContext)
    {
    }
}
