using Microsoft.AspNetCore.Mvc;

public static class TodoApi
{
    public static void MapTodoRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet(
            "/todo",
            ([FromServices] TodoRepo repo) =>
            {
                return Results.Ok(repo.GetAll());
            }
        );

        app.MapPost(
            "/todo/{title}",
            async ([FromRoute] string title, [FromServices] TodoRepo repo) =>
            {
                await repo.Add(new Todo(title));
                return Results.Ok();
            }
        );

        app.MapDelete(
            "/todo/{id}",
            async ([FromRoute] string id, [FromServices] TodoRepo repo) =>
            {
                await repo.Remove(id);
                return Results.Ok();
            }
        );

        app.MapPost)(
            "/convert",
            ()
        );
    }
}
