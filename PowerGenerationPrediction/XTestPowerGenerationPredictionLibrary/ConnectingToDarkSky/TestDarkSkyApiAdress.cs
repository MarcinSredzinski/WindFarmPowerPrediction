using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PowerGenerationPredictionLibrary;


namespace XTestPowerGenerationPredictionLibrary.ConnectingToDarkSky
{
    public class TestDarkSkyApiAdress
    {
        [Fact]
        public void DarkSkyApiAdressShouldBeCreated()
        {
            double longtitude = 1.1;
            double latitude = 2.2;
            long key = 44;
            DarkSkyApiAdress tworzenieAdresu = new DarkSkyApiAdress(longtitude, latitude, key);
            string expected = "https://api.darksky.net/forecast/44/2.2,1.1?extend=hourly&units=si";

            string actual = tworzenieAdresu.GenerateAdress();

            Assert.Equal(expected, actual);
        }

    }
}
