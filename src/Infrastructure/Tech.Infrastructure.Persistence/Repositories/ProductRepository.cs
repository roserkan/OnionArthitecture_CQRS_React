using Tech.Application.Interfaces.Repositories;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(TechDbContext dbContext) : base(dbContext)
    {
    }
}