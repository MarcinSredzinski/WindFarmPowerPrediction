using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
    public class DSWeather
    {
        internal double? ApparentTemperature { get; set; }
        [JsonProperty(PropertyName = "currently")]
        internal DSWeatherPoint Teraz { get; set; }
        [JsonProperty(PropertyName = "daily")]
        internal List<DSWeatherPoint> Daily { get; set; }
        //public WeatherBlock Dzien { get; set; }
        [JsonProperty(PropertyName = "hourly")]
        internal List<DSWeatherPoint> Hourly { get; set; }
        // public WeatherBlock CoGodzine { get; set; }
        [JsonProperty(PropertyName = "minutely")]
        internal List<DSWeatherPoint> Minutely { get; set; }
        //public WeatherBlock CoMinute { get; set; }
    }
}
