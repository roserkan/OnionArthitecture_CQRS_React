using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class UserCreateDto : IDto
{    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public Guid AddressId { get; set; }

}
