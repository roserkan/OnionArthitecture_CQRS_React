using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tech.Domain.Models;

namespace Tech.Infrastructure.Persistence.Contexts;
using System.Linq;
public class SeedData
{

    public async Task SeedAsync(IConfiguration configuration)
    {
        var dbContextBuilder = new DbContextOptionsBuilder();
        dbContextBuilder.UseNpgsql(configuration["TechDbConnectionString"]);
        var context = new TechDbContext(dbContextBuilder.Options);


        //address
        var addresses = new List<Address>();
        for (int i = 0; i < 100; i++)
        {
            var faker = new Faker("tr");
            var address = new Address()
            {
                Id = Guid.NewGuid(),
                CreatedDate = faker.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow),
                AddressLine = faker.Address.FullAddress()
            };

            addresses.Add(address);
        }
        var addressIds = addresses.Select(i => i.Id).ToList();
        await context.Addresses.AddRangeAsync(addresses);


        //users
        var users = new List<User>();
        for (int i = 0; i < 100; i++)
        {
            var faker = new Faker("tr");

            var user = new User()
            {
                Id = Guid.NewGuid(),
                CreatedDate = faker.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow),
                FirstName = faker.Person.FirstName,
                LastName = faker.Person.LastName,
                Email = faker.Person.Email,
                Password = faker.Internet.Password(),
                PhoneNumber = faker.Person.Phone,
                AddressId = addressIds[i],
            };

            users.Add(user);
        }
        var userIds = users.Select(i => i.Id).ToList();
        await context.Users.AddRangeAsync(users);


        //categories
        var categories = new List<Category>();
        var categoryList = new List<string>() { "Bilgisayar", "Telefon", "Televizyon", "Kamera"};
        for (int i = 0; i < 4; i++)
        {
            var faker = new Faker("tr");

            var category = new Category()
            {
                Id = Guid.NewGuid(),
                CreatedDate = faker.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow),
                CategoryName = categoryList[i],
            };

            categories.Add(category);
        }

        var categoryIds = categories.Select(i => i.Id).ToList();
        await context.Categories.AddRangeAsync(categories);


        //points
        var points = new List<Point>();
        for (int i = 0; i < 100; i++)
        {
            var faker = new Faker("tr");

            var point = new Point()
            {
                Id = Guid.NewGuid(),
                CreatedDate = faker.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow),
                PointValue = new Random().Next(1, 6),
            };

            points.Add(point);
        }

        var pointIds = points.Select(i => i.Id).ToList();
        await context.Points.AddRangeAsync(points);


        //products
        var productsPhone = new List<Product>();
        var productsLaptop = new List<Product>();

        var phoneList = new List<string>() {
            "Samsung Galaxy A51",
            "Samsung Galaxy S20 Ultra", 
            "Samsung Galaxy S20",
            "Samsung Galaxy S10e",
            "Samsung Galaxy S10 Plus", 
            "Samsung Galaxy Z Flip",
            "Samsung Galaxy Note 10",
            "Samsung Galaxy Note 10 Plus",
            "Samsung Galaxy S9",
            "Samsung Galaxy S9 Plus",
            "Samsung Galaxy Note 8",
            "Samsung Galaxy Fold",
            "Samsung Galaxy Fold 2",
            "Samsung Galaxy M31",
            "Samsung Galaxy M21",
            "Samsung Galaxy Note 10 Lite",
            "Samsung Galaxy A71",
            "Samsung Galaxy A90",
            "Samsung Galaxy M40",
            "iPhone 11",
            "iPhone 11 Pro",
            "iPhone X",
            "iPhone XS Max",
            "iPhone XR",
            "iPhone 8",
            "iPhone 8 Plus",
            "iPhone SE",
            "Huawei P30 Pro",
            "Huawei Mate 20 Pro",
            "Huawei P30",
            "Mi 10 Ultra",
            "Redmi Note 9 Pro",
            "Redmi Note 9",
            "Redmi 9",
            "Redmi Note 8",
            "Poco F2 Pro",
            "Redmi Note 8 Pro",
            "OPPO A31",
            "OPPO F15",
            "OPPO A5",
            "OPPO F9",
            "OPPO A9",
            "OPPO Reno2",
            "OPPO F3",
            "OPPO F5",
            "OPPO F7",
            "OPPO F11 Pro",
            "OPPO F5 Youth",
            "OPPO A83",
            "Vivo V17 Pro",
            "VIVO Z1x",
            "VIVO S1 Pro",
            "VIVO S1", 
            "VIVO V17",
            "VIVOZ1 Pro",
            "VIVO S1",
            "VIVO U20",
            "VIVO U10",
            "VIVO V15",
            "VIVO Y11",
            "Motorola Razr",
            "Mate X",
            "MOTO G8 Plus",
            "MOTO Z4",
            "Motorola One Action",
            "MOTO Z3",
            "MOTO G7 Power",
            "MOTO G7 Plus",
            "Motorola One Vision",
            "Lenovo Z5",
            "Lenovo K5 Note",
            "Lenovo P2",
            "Lenovo Z2 Plus",
            "Lenovo K6 Power",
            "Lenovo Vibe K5",
            "Lenovo Vibe K5 Note",
            "Lenovo Z5s",
            "Lenovo Z5 Pro GT",
            "LG G7 Plus ThinkQ",
            "LG W10 Alpha", 
            "LG V30 Plus",
            "LG Stylo 5",
            "LG Q70",
            "LGK61",
        }; // 84 telefon
        
        var laptopList = new List<string>()
        {
            "ASUS ZenBook Pro",
            "ASUS ZenBook Classic",
            "VivoBook S",
            "ASUS VivoBook Classic",
            "ASUS VivoBook Pro",
            "ASUS TUF Gaming",
            "ASUS Chromebook",
            "ASUS ROG Strix",
            "ASUS ROG Zephyrus",
            "ASUS ROG Mothership",
            "Zephyrus",
            "Dell Latitude 3000",
            "Dell Latitude 5000",
            "Dell Latitude 7000",
            "Dell Education",
            "Dell Rugged",
            "Dell Vostro 3000",
            "Dell Vostro 5000",
            "Dell Inspiron 3000",
            "Dell Inspiron 5000",
            "Dell Inspiron 7000",
            "Dell Precision 3000",
            "Dell Precision 5000",
            "Dell Precision 7000",
            "Dell XPS 13",
            "Dell XPS 15",
            "Dell Alienware m15",
            "Dell Alienware m17",
            "Dell Chromebook 11",
            "Dell Chromebook 14",
            "Dell G3",
            "Dell G5",
            "Dell G7",
            "ThinkPad T-Series",
            "ThinkPad X Series",
            "Lenovo IdeaPad 330",
            "Lenovo Ideapad 130",
            "Lenovo Yoga C",
            "Lenovo Flex 14",
            "Lenovo Flex 15",
            "Lenovo Flex 5",
            "Lenovo ChromeBook Flex 5",
            "Lenovo ChromeBook",
            "MacBook Pro 13",
            "MacBook Pro 15",
            "MacBook Pro 16",
            "MacBook Air 13",
            "MacBook 12"
        };

        for (int i = 0; i < 83; i++)
        {
            var faker = new Faker("tr");
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                CreatedDate = faker.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow),
                Name = phoneList[i],
                Description = faker.Commerce.ProductDescription(),
                Stock = new Random().Next(0, 101),
                Price = Double.Parse(faker.Commerce.Price()),
                PointId = faker.PickRandom(pointIds),
                CategoryId = categoryIds[1]
            };
            productsPhone.Add(product);
        }

        for (int i = 0; i < 47; i++)
        {
            var faker = new Faker("tr");

            var product = new Product()
            {
                Id = Guid.NewGuid(),
                CreatedDate = faker.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow),
                Name = laptopList[i],
                Description = faker.Commerce.ProductDescription(),
                Stock = new Random().Next(0, 101),
                Price = Double.Parse(faker.Commerce.Price()),
                PointId = faker.PickRandom(pointIds),
                CategoryId = categoryIds[0]

            };
            productsLaptop.Add(product);
        }


        //var productIds = products.Select(i => i.Id).ToList();
        await context.Products.AddRangeAsync(productsPhone);
        await context.Products.AddRangeAsync(productsLaptop);


        await context.SaveChangesAsync();
    }

    //public async Task SeedAsync(IConfiguration configuration)
    //{
    //    var dbContextBuilder = new DbContextOptionsBuilder();
    //    dbContextBuilder.UseNpgsql(configuration["TechDbConnectionString"]);

    //    var context = new TechDbContext(dbContextBuilder.Options);

    //    var addresses = new Faker<Address>("tr")
    //        .RuleFor(i => i.Id, i => Guid.NewGuid())
    //        .RuleFor(i => i.CreatedDate,
    //                    i => i.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow))
    //        .RuleFor(i => i.AddressLine, i => i.Address.FullAddress())
    //        .Generate(100);

    //    var addressIds = addresses.Select(i => i.Id).ToList();
    //    // 100 adres
    //    await context.Addresses.AddRangeAsync(addresses);



    //    var users = new Faker<User>("tr")
    //        .RuleFor(i => i.Id, i => Guid.NewGuid())
    //        .RuleFor(i => i.CreatedDate,
    //                    i => i.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow))
    //        .RuleFor(i => i.FirstName, i => i.Person.FirstName)
    //        .RuleFor(i => i.LastName, i => i.Person.LastName)
    //        .RuleFor(i => i.Email, i => i.Internet.Email())
    //        .RuleFor(i => i.Password, i => i.Internet.Password())
    //        .RuleFor(i => i.PhoneNumber, i => i.Person.Phone)
    //        .RuleFor(i => i.AddressId, i => i.PickRandom(addressIds))
    //        .Generate(100);

    //    var userIds = users.Select(i => i.Id).ToList();
    //    // 100 user
    //    await context.Users.AddRangeAsync(users);


    //    var categories = new Faker<Category>("tr")
    //      .RuleFor(i => i.Id, i => Guid.NewGuid())
    //      .RuleFor(i => i.CreatedDate,
    //                  i => i.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow))
    //      .RuleFor(i => i.CategoryName, i => i.Commerce.Department())
    //      .Generate(100);

    //    var categoryIds = categories.Select(i => i.Id).ToList();
    //    await context.Categories.AddRangeAsync(categories);


    //    var points = new Faker<Point>("tr")
    //      .RuleFor(i => i.Id, i => Guid.NewGuid())
    //      .RuleFor(i => i.CreatedDate,
    //                  i => i.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow))
    //      .RuleFor(i => i.PointValue, i => new Random().Next(1,6))
    //      .Generate(100);

    //    var pointIds = points.Select(i => i.Id).ToList();
    //    await context.Points.AddRangeAsync(points);


    //    var products = new Faker<Product>("tr")
    //      .RuleFor(i => i.Id, i => Guid.NewGuid())
    //      .RuleFor(i => i.CreatedDate,
    //                  i => i.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow))

    //      .RuleFor(i => i.Name, i => i.Commerce.ProductName())
    //      .RuleFor(i => i.Description, i => i.Commerce.ProductDescription())
    //      .RuleFor(i => i.Stock, i => new Random().Next(0, 101))
    //      .RuleFor(i => i.Price, i => Double.Parse(i.Commerce.Price()))
    //      .RuleFor(i => i.Name, i => i.Commerce.ProductName())
    //      .RuleFor(i => i.PointId, i => i.PickRandom(pointIds))
    //      .RuleFor(i => i.CategoryId, i => i.PickRandom(categoryIds))
    //      .Generate(100);

    //    var productIds = products.Select(i => i.Id).ToList();
    //    await context.Products.AddRangeAsync(products);


    //    //var comments = new Faker<Comment>("tr")
    //    //  .RuleFor(i => i.Id, i => Guid.NewGuid())
    //    //  .RuleFor(i => i.CreatedDate,
    //    //              i => i.Date.Between(DateTime.UtcNow.AddDays(-100), DateTime.UtcNow))
    //    //  .RuleFor(i => i.CommentValue, i => i.Lorem.Sentence(5, 5))
    //    //  .RuleFor(i => i.ProductId, i => i.PickRandom(productIds))
    //    //  .RuleFor(i => i.UserId, i => i.PickRandom(userIds))
    //    //  .Generate(100);

    //    //await context.Comments.AddRangeAsync(comments);


    //    await context.SaveChangesAsync();


    //}
}
