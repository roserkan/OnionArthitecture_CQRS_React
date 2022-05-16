using Tech.Application.Interfaces.Repositories;
using Tech.Domain.Models;
using Tech.Infrastructure.Persistence.Contexts;

namespace Tech.Infrastructure.Persistence.Repositories;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    public CommentRepository(TechDbContext dbContext) : base(dbContext)
    {
    }
}
