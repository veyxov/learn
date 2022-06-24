public interface ITodoService
{
    Task<List<Todo>> Get(int id);
    Task Add(Todo todo);
    Task Delete(int id);
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

    public Task Delete(int id)
    {
        var todo = _context.Todos.FirstOrDefault(t => t.Id == id) ?? throw new Exception("Todo not found");

        return Task.Run(() => _context.Todos.Remove(todo));
    }

    public Task<List<Todo>> Get(int id)
    {
        if (id == 0)
            return Task.Run(() => _context.Todos.ToList());
        return Task.Run(() => _context.Todos.Where(t => t.Id == id).ToList());
    }
}
