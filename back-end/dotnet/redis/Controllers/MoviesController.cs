using System.Diagnostics;
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
        var sw = new Stopwatch();
        sw.Start();

        string result = string.Empty;
        if (cached == 0) {
            result = GetFile();
            cach.SetString("text", result);
        } else {
            result = cach.GetString("text");
        }

        sw.Stop();
        return Ok(sw.ElapsedMilliseconds.ToString() + "\n" + result);
    }

    private string GetFile() {
        Thread.Sleep(5 * 1000);
        return System.IO.File.ReadAllText("data.json");
    }
}
