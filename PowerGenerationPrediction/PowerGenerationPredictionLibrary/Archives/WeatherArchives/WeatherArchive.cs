using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace PowerGenerationPredictionLibrary.Archives.WeatherArchives
{
    public class WeatherArchive
    {
        protected WeatherArchive(Forecasts.ForcastsInterfaces.IWeatherForecast forecast)
        {
            string name = PrepareArchiveName(forecast.ForecastSourceName);
            string archivePath = Path.Combine(PrepareArchivePath(), name);
            System.IO.Directory.CreateDirectory(archivePath);
        }
        public string PrepareArchiveName(string weatherSource)
        {
            return DateTime.Now.Year + weatherSource;
        }
        //todo get user archive or set default on desktop
        private string PrepareArchivePath()
        {
            //  string archivePath = @"C:\C:\Users\msred\Documents\GitHub\WindFarmPowerPrediction\PowerGenerationPrediction\archive";
            return  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        }
        private bool CheckIfArchiveExists(string archivePath)
        {
            return (File.Exists(archivePath));            
        }
    }
}