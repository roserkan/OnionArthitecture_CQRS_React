using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class AddressUpdateDto: IDto
{
    public Guid Id { get; set; }
    public string AddressLine { get; set; }
}
