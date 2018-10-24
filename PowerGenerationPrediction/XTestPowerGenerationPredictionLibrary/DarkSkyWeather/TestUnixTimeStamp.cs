using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PowerGenerationPredictionLibrary.DarkSkyWeather;
namespace XTestPowerGenerationPredictionLibrary.DarkSkyWeather
{
   public class TestUnixTimeStamp
    {
        [Fact]
        public void UnixTimeStampToDateTimeShouldConvert()
        {
            //arrange
            long unixTime = 1528190963;
            DateTime expected =DateTime.Parse("5.06.2018, 11:29:23");
            //act
            DateTime actual = UnixTimeStamp.ConvertUnixTimeStampToDateTime(unixTime);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
