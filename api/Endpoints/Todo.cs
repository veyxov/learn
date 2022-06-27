using LanguageExt.Common;
using Microsoft.AspNetCore.Mvc;

public static class Failer
{
    public static Result<string> ShouldFail(bool should)
    {
        var exception = new Exception("This is a test exception");
        if (should)
        {
            return new Result<string>(exception);
        }
        return "Hello World.";
    }
}

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

        app.MapPost(
            "/convert",
            (Transaction transaction) =>
            {
                var mapper = new TransactionMapper();
                var transactionResponse = mapper.Map(transaction);

                return Results.Ok(transactionResponse);
            }
        );

        app.MapGet(
                "/monad",
                (bool fail) =>
                {
                    var result = Failer.ShouldFail(fail);
                    return result.Match(success => Results.Ok(success), error => Results.BadRequest(error));
                }
                );
    }
}
