using CacheUp.Entities;

namespace CacheUp.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
