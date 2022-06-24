using MediatR;

public class TodoCreateHandler : IRequestHandler<TodoCreateRequest>
{
    private readonly ITodoService _todo;

    public TodoCreateHandler(ITodoService todo)
    {
        _todo = todo;
    }

    public async Task<Unit> Handle(TodoCreateRequest request, CancellationToken cancellationToken)
    {
        await _todo.Add(new Todo(request.Title, request.Description));
        return Unit.Value;
    }
}
