using AutoMapper;
using MediatR;
using Tech.Application.Dtos;
using Tech.Application.Features.Queries.Product.ViewModel;
using Tech.Application.Interfaces.Repositories;

namespace Tech.Application.Features.Queries.Product;

public class GetByUrlQuerieHandler : IRequestHandler<GetByUrlQuerie, ProductListViewModel>
{

    private readonly IProductRepository _productRepoistory;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public GetByUrlQuerieHandler(IProductRepository productRepoistory, IMapper mapper, ICategoryRepository categoryRepository)
    {
        _productRepoistory = productRepoistory;
        _mapper = mapper;
        _categoryRepository = categoryRepository;
    }

    public async Task<ProductListViewModel> Handle(GetByUrlQuerie request, CancellationToken cancellationToken)
    {
        var category =  _categoryRepository.Get(c => c.Url == request.Url).SingleOrDefault();
        var products = await _productRepoistory.GetList(p => p.CategoryId == category.Id);

        var filteredProducts = products.Skip((request.Page - 1) * request.PageSize).Take(request.PageSize);
        var dto = _mapper.Map<List<ProductListDto>>(filteredProducts);

        var result = new ProductListViewModel() { Products = dto, ProductCount = products.Count, PageSize = request.PageSize };

        return result;

    }
}
