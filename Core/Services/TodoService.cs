public interface ITodoService
{
    Task<List<Todo>> Get(Guid id);
    Task Add(Todo todo);
    Task Delete(Guid id);
}

public class TodoService : ITodoService
{
    private readonly TheContext _context;

    public TodoService(TheContext context)
    {
        _context = context;
    }

    public Task Add(Todo todo)
    {
        return Task.Run(() => _context.Todos.Add(todo));
    }

    public Task Delete(Guid id)
    {
        var todo = _context.Todos.FirstOrDefault(t => t.Id == id) ?? throw new Exception("Todo not found");

        return Task.Run(() => _context.Todos.Remove(todo));
    }

    public Task<List<Todo>> Get(Guid id)
    {
        if (id == Guid.Empty)
            return Task.Run(() => _context.Todos.ToList());
        return Task.Run(() => _context.Todos.Where(t => t.Id == id).ToList());
    }
}
