using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary.Forecasts.DarkSkyWeather
{
   public static class UnixTimeStamp
    {
        public static DateTime ConvertUnixTimeStampToDateTime(long unixTime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return  dtDateTime.AddSeconds(unixTime).ToLocalTime();
            
        }
    }
}
