using Microsoft.AspNetCore.Mvc;

namespace redis.Controllers;

[ApiController]
[Route("api")]
public class MoviesController : ControllerBase
{
    [HttpGet("movies")]
    public IActionResult GetAllMovies() {
        var cache = new RedisCache();
        return  Ok("arst");
    }
}
