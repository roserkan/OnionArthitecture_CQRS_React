using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class PointCreateDto : IDto
{
    public int PointValue { get; set; }
    public Guid ProductId { get; set; }
}

