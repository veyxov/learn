using Microsoft.AspNetCore.Mvc;

public static class TodoApi
{
    public static void MapTodoRoutes(this IEndpointRouteBuilder app)
    {
        app.MapPost("/todo/{title}", async ([FromRoute] string title, [FromServices] TodoRepo repo)
                     =>
        {
            return Results.Ok(await repo.GetAll());
        });

    }
}
