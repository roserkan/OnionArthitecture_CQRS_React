namespace Tech.Domain.Models;

public class Category : BaseEntity
{
    public string CategoryName { get; set; }
    public string Url { get; set; }

    public virtual ICollection<Product> Products { get; set; }

}





