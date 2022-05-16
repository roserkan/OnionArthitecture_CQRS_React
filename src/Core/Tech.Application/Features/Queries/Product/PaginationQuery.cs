using MediatR;
using Tech.Application.Dtos;
using Tech.Application.Features.Queries.Product.ViewModel;

namespace Tech.Application.Features.Queries.Product;

public class PaginationQuery: IRequest<ProductListViewModel>
{
    public int Page { get; set; }
    public int PageSize { get; set; } = 16;

    public PaginationQuery(int page = 1)
    {
        Page = page;
    }
}
