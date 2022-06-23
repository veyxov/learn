using MediatR;

public class HelloHandler : IRequestHandler<HelloRequest, string>
{
    public Task<string> Handle(HelloRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult($"Hello, {request.Message}");
    }
}
