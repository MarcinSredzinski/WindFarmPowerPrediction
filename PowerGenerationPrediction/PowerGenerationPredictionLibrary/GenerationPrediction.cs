using System;
using System.Collections.Generic;
using System.Text;
using PowerGenerationPredictionLibrary.PowerPlantModels;
using PowerGenerationPredictionLibrary.Forecasts.ForecastsInterfaces;

namespace PowerGenerationPredictionLibrary
{
    public  class GenerationPrediction<T> where T:class, new()
    {
        //todo bad approach - this construction forces caller to know what kind of response is awaited instead of knowing which forecast API to use!
        private IPowerPlantModel _powerPlantModel;
        private IWeatherForecast<T> _weatherForecast;
        public GenerationPrediction(IPowerPlantModel powerPlantModel, IWeatherForecast<T> weatherForecast)
        {
            _powerPlantModel = powerPlantModel;
            _weatherForecast = weatherForecast;
        }

        public static void PredictPower()
        { }
        public static void PredictEnergy()
        { }
    }
}


//Ilocalization lokalizacja = Z Factry( new localization(long, lat))
//IPowerPlantModel model =Z Factry( new Model(gen, gear, tower, Turbine, Rotor))
//przykładowe użycie//
//IweatherFoecast  weatherForecast = DarkSkyWeatherForecast.Predict(localization, timeSpan)
//IPowerPrediction = z Factory (new PowerPrediction( model, weatherForecast )