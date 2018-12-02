using System.Collections.Generic;
namespace PowerGenerationPredictionLibrary.Forecasts.ForecastsInterfaces
{
    public interface IWeatherForecast<T> where T: class, new()
    {
        string ForecastSourceName { get; }
        ILocalization Localization { get; set; }
        T GetForecast(ForecastsInterfaces.IApiAddress apiAddress);
        void Save(string archivePath);
    }
}