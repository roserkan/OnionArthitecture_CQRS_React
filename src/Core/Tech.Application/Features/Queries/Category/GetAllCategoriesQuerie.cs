using MediatR;
using Tech.Application.Dtos;

namespace Tech.Application.Features.Queries.Category;

public class GetAllCategoriesQuerie: IRequest<List<CategoryListDto>>
{
}
