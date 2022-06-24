using Microsoft.AspNetCore.Mvc;

public static class TodoApi
{
    public static void MapTodoRoutes(this IEndpointRouteBuilder app)
    {
        app.MapPost("/todo/{title}", ([FromRoute] string title, [FromServices] TodoRepo repo)
                     =>
        {
            repo.Add(new Todo(title));
            return Results.Ok();
        });

    }
}
