using System.Collections.Generic;
namespace PowerGenerationPredictionLibrary.Forecasts.ForecastsInterfaces
{
    public interface IWeatherForecast
    {
        string ForecastSourceName { get; }
        ILocalization Localization { get; set; }
        object GetForecast(ForecastsInterfaces.IApiAddress apiAddress);
        void Save(string archivePath);
    }
}