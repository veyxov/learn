using MediatR;

public class HelloRequest : IRequest<HelloResponse>
{
    public string Message { get; set; } = "This is a message.";
}
