using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
    public class DSWeatherPoint
    {
        [JsonProperty(PropertyName = "time")]
        internal long TimeUnix { get; set; }
        public DateTimeOffset DateTime => UnixTimeStamp.ConvertUnixTimeStampToDateTime(TimeUnix);

        [JsonProperty(PropertyName = "humidity")]
        public double? Humidity { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public double? Pressure { get; set; }

        [JsonProperty(PropertyName = "temperature")]
        public double? Temperature { get; set; }

        [JsonProperty(PropertyName = "windBearing")]
        public int? WindBearing { get; set; }

        [JsonProperty(PropertyName = "windSpeed")]
        public double? WindSpeed { get; set; }
    }
}
