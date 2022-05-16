using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tech.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Tech.Application.Interfaces.Repositories;
using Tech.Infrastructure.Persistence.Repositories;

namespace Tech.Infrastructure.Persistence.Extensions;

public static class Registration
{
    public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TechDbContext>(conf =>
        {
            var connStr = configuration["TechDbConnectionString"].ToString();
            Console.WriteLine(connStr);
            conf.UseNpgsql(connStr, opt =>
            {
                opt.EnableRetryOnFailure();
            });
        });


        //var seedData = new SeedData();
        //seedData.SeedAsync(configuration).GetAwaiter().GetResult();

        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IPointRepository, PointRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUserRepository, UserRepository>();





        return services;
    }
}
