public interface ITodoService
{
    Task<List<Todo>> GetAll();
    Task Add(Todo todo);
    Task Delete(int id);
}

public class TodoService : ITodoService
{
    private readonly TodoContext _context;

    public TodoService(TodoContext context)
    {
        _context = context;
    }
}
