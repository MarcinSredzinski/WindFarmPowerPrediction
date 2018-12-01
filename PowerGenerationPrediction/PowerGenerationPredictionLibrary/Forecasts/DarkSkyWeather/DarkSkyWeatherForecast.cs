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
    public class DarkSkyWeatherForecast<T> : IWeatherForecast<T>
    {
        //string _weatherJson;
        //public DarkSkyWeatherForecast()
        //{

        //}
        //public string ForecastSourceName { get { return "DarkSky"; } }    

        //public ILocalization Localization { get; set; }

        ////todo really bad practice, change is needed in near future! 
        ////Possible solution to this problem may be creating interface representing potential response. 
        //public T GetForecast(ForecastsInterfaces.IApiAddress apiAddress)
        //{
        //    T weather;            
        //    _weatherJson = new WebClient().DownloadString(apiAddress.GenerateAdress());
        //    weather = JsonConvert.DeserializeObject<T> (_weatherJson);
        //    return weather;
        //}

        //public void Save(string archivePath)
        //{
        //    File.WriteAllTextAsync(archivePath, _weatherJson);
        //}
    }
}
