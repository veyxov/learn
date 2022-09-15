using System.Text.Json;

public class Button
{
    public string Text { get; set; } = null!;
    public string Color { get; set; } = null!;
}

public class RedButton : Button
{
    public RedButton(string text)
    {
        Text = text;
        Color = "Red";
    }
}

public enum ButtonType
{
    Normal,
    Red
}

// Factory
public static class ButtonFactory
{
    // Factory method
    public static Button CreateButton(ButtonType type)
    {
        if (type == ButtonType.Normal)
            return new Button() {Text = "Normal text", Color = "White"};
        else if (type == ButtonType.Red)
            return new RedButton("Red text");

        throw new Exception("Undefined button type");
    }
}

public class Program
{
    public static void Main()
    {
        var normalButton = ButtonFactory.CreateButton(ButtonType.Normal);
        var redButton = ButtonFactory.CreateButton(ButtonType.Red);

        Helpers.Print(normalButton);
        Helpers.Print(redButton);
    }
}

// Helper functions
public static class Helpers
{
    public static void Print(object obj)
    {
        Console.WriteLine(JsonSerializer.Serialize(obj, new JsonSerializerOptions {WriteIndented = true}));
    }
}
