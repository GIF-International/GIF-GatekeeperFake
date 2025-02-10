using System.Net;
using GatekeeperFake.Api.Models;
using GatekeeperFake.SDK.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GatekeeperFake.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<TestsController> _logger;

    public TestsController(ILogger<TestsController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetWeatherForecast")]
    public IEnumerable<WeatherForecast> GetWeatherForecast()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("GetSayHelloFromGrpc")]
    public async Task<IActionResult> GetSayHelloFromGrpc([FromServices] IGreeterGrpcService greeterGrpcService)
    {
        var result = await greeterGrpcService.SayHelloAsync("gRPC");

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }
}
