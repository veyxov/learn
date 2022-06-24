public interface ITodoService
{
    Task<List<Todo>> GetAll();
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

    public Task<List<Todo>> GetAll()
    {
        return Task.Run(() => _context.Todos.ToList());
    }
}
