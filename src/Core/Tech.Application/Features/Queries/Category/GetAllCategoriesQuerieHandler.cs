using AutoMapper;
using MediatR;
using Tech.Application.Dtos;
using Tech.Application.Interfaces.Repositories;

namespace Tech.Application.Features.Queries.Category;

public class GetAllCategoriesQuerieHandler : IRequestHandler<GetAllCategoriesQuerie, List<CategoryListDto>>
{

    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public GetAllCategoriesQuerieHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<List<CategoryListDto>> Handle(GetAllCategoriesQuerie request, CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetAll();

        var result = _mapper.Map<List<CategoryListDto>>(categories);

        return result;

    }
}
