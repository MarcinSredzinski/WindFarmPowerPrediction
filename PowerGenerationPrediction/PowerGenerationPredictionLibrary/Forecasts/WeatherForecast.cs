using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace PowerGenerationPredictionLibrary.Forecasts
{
    class WeatherForecast<T> : ForecastsInterfaces.IWeatherForecast<T>
    {
        string _weatherJson;
      
        public string ForecastSourceName => typeof(T).Name;

        public ILocalization Localization { get; set; }
        
        public T GetForecast(ForecastsInterfaces.IApiAddress apiAddress)
        {
            T weather;
            _weatherJson = new WebClient().DownloadString(apiAddress.GenerateAdress());
            weather = JsonConvert.DeserializeObject<T>(_weatherJson);
            return weather;
        }

        public void Save(string archivePath)
        {
            File.WriteAllTextAsync(archivePath, _weatherJson);
        }

    }
}
