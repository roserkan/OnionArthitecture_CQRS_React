using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class CategoryUpdateDto : IDto
{
    public Guid Id { get; set; }
    public string CategoryName { get; set; }
    public string Url { get; set; }

}
