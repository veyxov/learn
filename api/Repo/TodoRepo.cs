using Dapper;

public class TodoRepo
{
    private readonly DapperContext _context;
    public TodoRepo(DapperContext context)
    {
        _context = context;
    }

    public Task Add(Todo todo)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Todo>> GetAll()
    {
        var query = "SELECT * FROM Todos";
        using (var connection = _context.CreateConnection())
        {
            var todo = connection.Query<Todo>(query);
            return todo.ToList();
        }
    }
}
