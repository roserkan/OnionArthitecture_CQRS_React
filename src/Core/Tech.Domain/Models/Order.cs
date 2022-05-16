namespace Tech.Domain.Models;

public class Order : BaseEntity
{
    public virtual Guid UserId { get; set; }
    public virtual User User { get; set; }

    public virtual Guid ProductId { get; set; }
    public virtual Product Product { get; set; }

    public int Quantity { get; set; }


}





