using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
    public class DSWeather
    {
        public double? ApparentTemperature { get; set; }
        [JsonProperty(PropertyName = "currently")]
        public WeatherPoint Teraz { get; set; }
        [JsonProperty(PropertyName = "daily")]
        public List<WeatherPoint> Daily { get; set; }
        //public WeatherBlock Dzien { get; set; }
        [JsonProperty(PropertyName = "hourly")]
        public List<WeatherPoint> Hourly { get; set; }
        // public WeatherBlock CoGodzine { get; set; }
        [JsonProperty(PropertyName = "minutely")]
        public List<WeatherPoint> Minutely { get; set; }
        //public WeatherBlock CoMinute { get; set; }
    }
}
