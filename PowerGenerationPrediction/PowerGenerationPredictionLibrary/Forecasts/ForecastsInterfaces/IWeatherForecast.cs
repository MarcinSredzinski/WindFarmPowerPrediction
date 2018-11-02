namespace PowerGenerationPredictionLibrary.Forecasts.ForcastsInterfaces
{
    public interface IWeatherForecast
    {
        string ForecastSourceName { get; }
        System.Collections.ArrayList WeatherForecast { get; } 
    }
}