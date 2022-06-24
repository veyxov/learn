public class Todo
{
    public Todo(string title, string desc)
    {
        Title = title;
        Description = desc;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsCompleted { get; set; }
}
