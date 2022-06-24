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

    [HttpGet]
    public async Task<IActionResult> Get(TodoCreateRequest request)
    {
        await _mediator.Send(request);
        return Ok();
    }
}
