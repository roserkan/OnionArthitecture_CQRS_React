using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class UserUpdateDto : IDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public Guid AddressId { get; set; }

}
