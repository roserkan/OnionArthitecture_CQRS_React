using MediatR;
using Tech.Application.Dtos;

namespace Tech.Application.Features.Queries.Products;

public class GetAllProductsQuerie: IRequest<List<ProductListDto>>
{
}
