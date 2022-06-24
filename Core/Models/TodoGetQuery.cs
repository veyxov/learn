using MediatR;

public class TodoGetQuery : IRequest<List<Todo>>
{
    public Guid Id { get; set; }
}
