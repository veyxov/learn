using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/todo")]
public class TodoController : ControllerBase
{
    private readonly IMediator _mediator;

    public TodoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Post(TodoCreateRequest request)
    {
        await _mediator.Send(request);
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<List<Todo>>> Get(TodoGetQuery query)
    {
        return Ok(await _mediator.Send(query));
    }
}
