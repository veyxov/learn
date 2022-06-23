using MediatR;

public class HelloRequest : IRequest<string>
{
    public string Message { get; set; } = "This is a message.";
}
