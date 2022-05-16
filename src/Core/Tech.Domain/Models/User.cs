namespace Tech.Domain.Models;

public class User: BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }

    public virtual  Guid AddressId { get; set; }
    public virtual Address Address { get; set; }

    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<Order> Orders { get; set; }

}





