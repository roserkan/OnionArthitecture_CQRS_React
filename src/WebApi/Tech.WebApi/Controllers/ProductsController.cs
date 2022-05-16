using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tech.Application.Features.Queries.Product;
using Tech.Application.Features.Queries.Products;

namespace Tech.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllProductsQuerie());
        return Ok(result);
    }

    [HttpGet]
    [Route("getallwithpagination")]
    public async Task<IActionResult> GetByPage(int page = 1)
    {
        var result = await _mediator.Send(new PaginationQuery(page));
        return Ok(result);
    }

    [HttpGet]
    [Route("getbyurl")]
    public async Task<IActionResult> GetByUrl(string url, int page = 1)
    {
        var result = await _mediator.Send(new GetByUrlQuerie(url, page));
        return Ok(result);
    }
}
