namespace Tech.Domain.Models;

public class Point : BaseEntity
{
    public int PointValue { get; set; }
    public virtual Product Product { get; set; }
}




