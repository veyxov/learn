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
        var query = @"INSERT INTO Todos (Id, Title) VALUES (@Id, @Title)";
        using (var connection = _context.CreateConnection())
        {
            return connection.ExecuteAsync(query, new { todo.Id, todo.Title });
        }
    }

    public List<Todo> GetAll()
    {
        var query = "SELECT * FROM Todos";
        using (var connection = _context.CreateConnection())
        {
            var todo = connection.Query<Todo>(query);
            return todo.ToList();
        }
    }
}
