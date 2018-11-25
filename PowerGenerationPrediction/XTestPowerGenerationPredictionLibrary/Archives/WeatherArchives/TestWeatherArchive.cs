using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PowerGenerationPredictionLibrary.Archives.WeatherArchives;
namespace XTestPowerGenerationPredictionLibrary.Archives.WeatherArchives
{
    public class TestWeatherArchive
    {
        [Fact]
        public void PrepareArchiveNameTest()
        {
            //arrange
            string weatherSource = "DarkSkyApi";
            string expected = DateTime.Now.Year.ToString() + weatherSource;
            //act
        //    PowerGenerationPredictionLibrary.Archives.WeatherArchives.WeatherArchive weatherArchive = new PowerGenerationPredictionLibrary.Archives.WeatherArchives.WeatherArchive();
          //  string actual = weatherArchive.PrepareArchiveName(weatherSource);
            //assert
         //   Assert.Equal(expected, actual);
        }

       
    }
}
