using System.Security.Cryptography;
using Teqniqly.Results;

namespace WebApiSample.Services
{
    internal sealed record CityNotFoundError(string Message, string City) : Error(Message);

    internal static class WeatherForecastService
    {
        private static readonly string[] Summaries =
        [
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching",
        ];

        private static readonly string[] ValidCities = ["Seattle"];

        internal static IResult<IEnumerable<WeatherForecast>> GetWeatherForecast(string city)
        {
            if (!ValidCities.Contains(city, StringComparer.OrdinalIgnoreCase))
            {
                return Result.Failure<IEnumerable<WeatherForecast>>(
                    new CityNotFoundError("City not found", city)
                );
            }
            var forecasts = Enumerable
                .Range(1, 5)
                .Select(index => new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = RandomNumberGenerator.GetInt32(-20, 55),
                    Summary = Summaries[RandomNumberGenerator.GetInt32(Summaries.Length)],
                });

            return Result.Success(forecasts);
        }
    }
}
