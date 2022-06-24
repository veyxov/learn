using MediatR;

public class TodoGetQuery : IRequest<List<Todo>>
{
    public int Id { get; set; }
}
