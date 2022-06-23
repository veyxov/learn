using MediatR;

public class HelloHandler : IRequestHandler<HelloRequest, HelloResponse>
{
    public Task<HelloResponse> Handle(HelloRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new HelloResponse
        {
            Message = $"Hello {request.Message}!"
        });
    }
}
