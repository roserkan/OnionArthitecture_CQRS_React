using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class ProductCreateDto : IDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }

    public Guid PointId { get; set; }

    public Guid CategoryId { get; set; }

}
