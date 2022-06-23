public class HelloModel
{
    public HelloModel(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
    public DateTime CreationDate { get; set; }

    ~HelloModel()
    {
        Console.WriteLine("HelloModel is being garbage collected");
    }
}

