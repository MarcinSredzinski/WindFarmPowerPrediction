using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary.DarkSkyWeather
{
   public static class UnixTimeStamp
    {
        public static DateTime ConvertUnixTimeStampToDateTime(long unixTime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTime).ToLocalTime();
            return dtDateTime;
        }
    }
}
