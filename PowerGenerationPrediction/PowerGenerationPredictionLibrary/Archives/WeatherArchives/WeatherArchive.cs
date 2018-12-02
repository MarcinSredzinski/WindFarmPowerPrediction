using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using PowerGenerationPredictionLibrary.Forecasts.ForecastsInterfaces;
namespace PowerGenerationPredictionLibrary.Archives.WeatherArchives
{
    public class WeatherArchive<T> where T:class, new()
    {
        protected WeatherArchive(IWeatherForecast<T> forecast)
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