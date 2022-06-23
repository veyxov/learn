using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class HelloController : ControllerBase
{
    private readonly IMediator _mediator;

    public HelloController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("/hello")]
    public async Task<ActionResult<HelloResponse>> GetAsync(HelloRequest request)
    {
        return Ok(await _mediator.Send(request));
    }
}
