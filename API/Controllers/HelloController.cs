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

    [HttpGet("/hello")]
    public async Task<string> GetAsync()
    {
        var result = _mediator.Send(new HelloRequest());
        return await result;
    }
}
