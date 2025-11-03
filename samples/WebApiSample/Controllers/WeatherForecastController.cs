using Microsoft.AspNetCore.Mvc;
using WebApiSample.Services;

namespace WebApiSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("{city}")]
        public ActionResult<IEnumerable<WeatherForecast>> Get([FromRoute] string city)
        {
            var result = WeatherForecastService.GetWeatherForecast(city);

            if (!result.IsFailure)
            {
                return Ok(result.GetValue());
            }

            var error = result.GetError();

            return error switch
            {
                CityNotFoundError => Problem(
                    error.Message,
                    statusCode: StatusCodes.Status404NotFound
                ),
                _ => Problem(error.Message, statusCode: StatusCodes.Status400BadRequest),
            };
        }
    }
}
