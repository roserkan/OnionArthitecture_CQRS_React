using Tech.Application.Interfaces.Dto;

namespace Tech.Application.Dtos;

public class CommentCreateDto : IDto
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }
    public string CommentValue { get; set; }
}

