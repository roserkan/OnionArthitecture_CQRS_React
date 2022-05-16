namespace Tech.Domain.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }

    public virtual Guid PointId { get; set; }
    public virtual Point Point { get; set; }


    public virtual Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }

    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<Order> Orders { get; set; }

}





