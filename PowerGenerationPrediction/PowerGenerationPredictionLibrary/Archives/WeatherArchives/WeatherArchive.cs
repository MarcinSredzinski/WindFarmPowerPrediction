using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary.Archives.WeatherArchives
{
    public class WeatherArchive
    {
        public string PrepareArchiveName(string weatherSource)
        {
            string archiveName = DateTime.Now.Year + weatherSource;
            return archiveName;
        }
    }
}