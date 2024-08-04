using Microsoft.AspNetCore.Mvc;

namespace Example.Ping.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PingPongController : ControllerBase
{
    private readonly ILogger<PingPongController> _logger;

    public PingPongController(ILogger<PingPongController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Ping")]
    public async Task<IActionResult> Ping()
    {
        await Task.Delay(TimeSpan.FromSeconds(35));
        return Ok("Pong");
    }
}
