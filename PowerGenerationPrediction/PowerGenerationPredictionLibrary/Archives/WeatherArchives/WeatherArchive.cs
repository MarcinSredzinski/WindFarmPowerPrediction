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
            string name = PrepareArchiveName(forecast.ForecastName);
            string archivePath = Path.Combine(PrepareArchivePath(), name);
            System.IO.Directory.CreateDirectory(archivePath);
        }
        public string PrepareArchiveName(string weatherSource)
        {
            string archiveName = DateTime.Now.Year + weatherSource;
            return archiveName;
        }
        //todo get user archive or set default on desktop
        private string PrepareArchivePath()
        {
            string defaultArchivePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
          //  string archivePath = @"C:\C:\Users\msred\Documents\GitHub\WindFarmPowerPrediction\PowerGenerationPrediction\archive";
            return defaultArchivePath;
        }
        private bool CheckIfArchiveExists(string archivePath)
        {
            bool archiveExists = (File.Exists(archivePath)) ? true : false;
            return archiveExists;
        }
    }
}