namespace Tech.Domain.Models;

public class Address : BaseEntity
{
    public string AddressLine { get; set; }
    public virtual User User { get; set; }

}
