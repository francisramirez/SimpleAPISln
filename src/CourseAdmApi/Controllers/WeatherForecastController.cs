using Microsoft.AspNetCore.Mvc;

namespace CourseAdmApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing test", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy Test 7", "Hot Test 6", "Sweltering Test 5", "Scorching Test 3"
    };

    public WeatherForecastController()
    {
        
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet("GetMyName")]

    public ActionResult<string> GetMyName()
    {
        return "Francis Ramirez";
    }
}
