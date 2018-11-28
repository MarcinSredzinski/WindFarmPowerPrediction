using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PowerGenerationPredictionLibrary.Forecasts.ForecastsInterfaces;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
    public class DarkSkyWeatherForecast : IWeatherForecast
    {
        string _weatherJson;
        public DarkSkyWeatherForecast()
        {

        }
        public string ForecastSourceName { get { return "DarkSky"; } }    

        public ILocalization Localization { get; set; }

        //todo really bad practice, change is needed in near future! 
        //Possible solution to this problem may be creating interface representing potential response. 
        public object GetForecast(ForecastsInterfaces.IApiAddress apiAddress)
        {           
            DSWeather weather = new DSWeather();
           
            _weatherJson = new WebClient().DownloadString(apiAddress.GenerateAdress());
            weather = JsonConvert.DeserializeObject<DSWeather>(_weatherJson);
            return weather;
        }

        public void Save(string archivePath)
        {
            File.WriteAllTextAsync(archivePath, _weatherJson);
        }
    }
}
