using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace redis.Controllers;

[ApiController]
[Route("api")]
public class MoviesController : ControllerBase
{
    [HttpGet("movies")]
    public IActionResult GetAllMovies([FromServices] IDistributedCache cach, int cached)
    {
        if (cached == 0)
        {
            return Ok(GetFile());
        }

        return Ok("no data");
    }

    private string GetFile() {
        Thread.Sleep(5 * 1000);
        return System.IO.File.ReadAllText("data.json");
    }
}
