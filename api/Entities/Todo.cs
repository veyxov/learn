public class Todo
{
    public Todo(string title)
    {
        Title = title;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
}

public class TodoCreateDto
{
    public string Title { get; set; } = string.Empty;
}
