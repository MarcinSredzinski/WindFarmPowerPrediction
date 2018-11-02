using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary
{
    public class Localization: ILocalization
    {
        public double Longtitude { get; }// set; }
        public double Latitude { get; }// set; }

        public Localization(double longtitude, double latitude)
        {
            Longtitude = longtitude;
            Latitude = latitude;
        }
    }
}
