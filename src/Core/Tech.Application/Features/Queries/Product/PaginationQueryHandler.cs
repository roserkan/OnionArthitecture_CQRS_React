using AutoMapper;
using MediatR;
using Tech.Application.Dtos;
using Tech.Application.Features.Queries.Product.ViewModel;
using Tech.Application.Interfaces.Repositories;

namespace Tech.Application.Features.Queries.Product;

public class PaginationQueryHandler : IRequestHandler<PaginationQuery, ProductListViewModel>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public PaginationQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ProductListViewModel> Handle(PaginationQuery request, CancellationToken cancellationToken)
    {
        var page = request.Page;
        var pageSize = request.PageSize;

        var products =  await _productRepository.GetAll();
        var filteredProducts = products.Skip((page - 1) * pageSize).Take(pageSize);
        var dto = _mapper.Map<List<ProductListDto>>(filteredProducts);
        var result = new ProductListViewModel() { Products = dto, ProductCount = products.Count, PageSize = pageSize};

        return result;
    }
}
