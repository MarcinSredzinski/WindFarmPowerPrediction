using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary
{
    public class DarkSkyApiAdress
    {
        private string baseAdress = "https://api.darksky.net/forecast/";
        private double _longtitude;
        private double _latitude;
        private long _apiKey;
        private string extend = "extend=hourly";
        string unit = "si";

        /// <summary>
        /// DarkSkyApiAdress object helps to generate ApiCall adress
        /// </summary>
        /// <param name="longtitude">Is geographical longtitude</param>
        /// <param name="latitude">Is geographical latitude</param>
        /// <param name="apiKey">Must consist of valid Dark Sky api key</param>
        public DarkSkyApiAdress(double longtitude, double latitude, long apiKey)
        {
            _longtitude = longtitude;
            _latitude = latitude;
            _apiKey = apiKey;
        }
        /// <summary>
        /// Returns adress allowing to make a call to the api
        /// </summary>
        /// <returns> </returns>
        public string GenerateAdress()
        {
            string latitudeWithCommas = _latitude.ToString().Replace(',', '.');
            string longtitudeWithCommas = _longtitude.ToString().Replace(',', '.');
            string adress = $"{baseAdress}{_apiKey}/{latitudeWithCommas},{longtitudeWithCommas}?{extend}&units={unit}";
            return adress;
        }        

    }
}
