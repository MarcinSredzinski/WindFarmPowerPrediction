using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PowerGenerationPredictionLibrary.Forecasts.ForcastsInterfaces;
using Newtonsoft.Json;
using System.Net;

namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
    public class DarkSkyWeatherForecast : IWeatherForecast
    {
        public DarkSkyWeatherForecast()
        {

        }
        public string ForecastSourceName { get { return "DarkSky"; } }


        public ArrayList WeatherForecast()
        {
            ArrayList arrayList = new ArrayList();
            return arrayList;
                
        }

        public ILocalization Localization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public DSWeather GetForecast(ForecastsInterfaces.IApiAddress apiAddress)
        {
            DSWeather weather = new DSWeather();
            string weatherJson = new WebClient().DownloadString(apiAddress.GenerateAdress());
            weather = JsonConvert.DeserializeObject<DSWeather>(weatherJson);
            return weather;
        }

        public void SaveServerResponse()
        {
        }
    }
}
