using Microsoft.AspNetCore.Mvc;

public static class TodoApi
{
    public static void MapTodoRoutes(this IEndpointRouteBuilder app)
    {
        app.MapPost("/todo/{title}", ([FromRoute] string title, [FromServices] TodoRepo repo)
                     =>
        {
            return Results.Ok(new Todo(title));
        });

    }
}
