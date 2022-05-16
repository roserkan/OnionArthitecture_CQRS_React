using MediatR;
using Tech.Application.Dtos;
using Tech.Application.Features.Queries.Product.ViewModel;

namespace Tech.Application.Features.Queries.Product;

public class GetByUrlQuerie: IRequest<ProductListViewModel>
{
    public string Url { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; } = 16;
    public GetByUrlQuerie(string url, int page)
    {
        Url = url;
        Page = page;
    }
}
