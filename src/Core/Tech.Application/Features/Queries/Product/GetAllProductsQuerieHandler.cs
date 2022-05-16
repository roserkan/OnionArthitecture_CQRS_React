using AutoMapper;
using MediatR;
using Tech.Application.Dtos;
using Tech.Application.Features.Queries.Products;
using Tech.Application.Interfaces.Repositories;
using Tech.Domain.Models;

namespace Tech.Application.Features.Queries.Products;

public class GetAllProductsQuerieHandler : IRequestHandler<GetAllProductsQuerie, List<ProductListDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetAllProductsQuerieHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<List<ProductListDto>> Handle(GetAllProductsQuerie request , CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAll();

        var result = _mapper.Map<List<ProductListDto>>(products);
        
        return result;
    }
}
