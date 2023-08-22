using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Configurations.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class WeatherForecastController : ControllerBase
    {
        private readonly IOptions<ConfigObject> _config;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };



        public WeatherForecastController(IOptions<ConfigObject> config) { _config = config; }


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            Console.WriteLine(_config.Value.Logging.LogLevel.Default);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}