using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class AddressCreateDto: IDto
{
    public Guid Id { get; set; }
    public string AddressLine { get; set; }
}
