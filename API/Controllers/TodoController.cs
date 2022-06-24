using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class TodoController : ControllerBase
{
    private readonly IMediator _mediator;

    public TodoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("/a")]
    public async Task<ActionResult<HelloResponse>> GetAsync(HelloRequest request)
    {
        return Ok(await _mediator.Send(request));
    }
}
