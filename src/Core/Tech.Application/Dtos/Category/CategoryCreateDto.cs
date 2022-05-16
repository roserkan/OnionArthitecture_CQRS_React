using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class CategoryCreateDto : IDto
{
    public string CategoryName { get; set; }
    public string Url { get; set; }

}
