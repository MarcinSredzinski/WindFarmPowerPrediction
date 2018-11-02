using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PowerGenerationPredictionLibrary.Forecasts.ForcastsInterfaces;

namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
    public class DarkSkyWeatherForecast : IWeatherForecast
    {
        public DarkSkyWeatherForecast()
        {

        }
        public string ForecastSourceName { get { return "DarkSky"; } }


        public ArrayList WeatherForecast => throw new NotImplementedException();
        //GetForecast(ApiAddress)

    }
}
