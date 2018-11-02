namespace PowerGenerationPredictionLibrary.Forecasts.ForcastsInterfaces
{
    public interface IWeatherForecast
    {
        string ForecastSourceName { get; }
        ILocalization Localization { get; set; }
        System.Collections.ArrayList WeatherForecast { get; } 
    }
}