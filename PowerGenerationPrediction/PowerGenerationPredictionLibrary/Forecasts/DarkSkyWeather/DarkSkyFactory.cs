using System;
using System.Collections.Generic;
using System.Text;
using PowerGenerationPredictionLibrary.Forecasts.ForecastsInterfaces;
namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
    public class DarkSkyFactory
    {
        public DarkSkyApiAddress CreateDarkSkyApiAdress(double longtitude, double latitude, long apiKey)=> new DarkSkyApiAddress(longtitude, latitude, apiKey);
        
        public IWeatherForecast<DSWeather> CreatedarkSkyWeatherForecast()=> new WeatherForecast<DSWeather>();
        
        public DSWeather CreateDSWeather() => new DSWeather();
        
        public DSWeatherPoint CreateDSWeatherPoint() => new DSWeatherPoint();
    }
}
