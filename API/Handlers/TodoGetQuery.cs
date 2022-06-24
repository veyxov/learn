using MediatR;

public class TodoGetHandler : IRequestHandler<TodoGetQuery, List<Todo>>
{
    private readonly ITodoService _todoService;

    public TodoGetHandler(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public Task<List<Todo>> Handle(TodoGetQuery request, CancellationToken cancellationToken)
    {
        return _todoService.Get(request.Id);
    }
}
