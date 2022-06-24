public class Todo
{
    public Todo() { }

    public Todo(string title)
    {
        Title = title;
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
    public string Title { get; set; }
}

public class TodoCreateDto
{
    public string Title { get; set; } = string.Empty;
}
