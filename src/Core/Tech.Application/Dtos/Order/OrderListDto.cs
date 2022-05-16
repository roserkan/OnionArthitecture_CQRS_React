using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class OrderListDto: IDto
{
    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
