using Tech.Application.Dtos;

namespace Tech.Application.Features.Queries.Product.ViewModel;

public class ProductListViewModel
{
    public List<ProductListDto> Products { get; set; }
    public int ProductCount { get; set; }
    public int PageSize { get; set; }
}
