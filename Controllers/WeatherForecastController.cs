using Microsoft.AspNetCore.Mvc;

namespace SampleAPIApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       // int num1;
        private static readonly string[] Summaries = new[]
        {
            "Deep Freezing", "Bracing", "Chilly", "Gool", "Mild", "Warm", "Balmy", "Hotter", "Sweltering", "Scorching"
        };

       // private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController()
        {
            num1 = 100;
           // _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            //_logger.LogWarning("Invoked");
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
