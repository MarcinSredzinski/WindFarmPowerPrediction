using System;
using System.Collections.Generic;
using System.Text;
using PowerGenerationPredictionLibrary.PowerPlantModels;
using PowerGenerationPredictionLibrary.Forecasts.ForecastsInterfaces;

namespace PowerGenerationPredictionLibrary
{
    public  class GenerationPrediction
    {
        private IPowerPlantModel _powerPlantModel;
        private IWeatherForecast _weatherForecast;
        public GenerationPrediction(IPowerPlantModel powerPlantModel, IWeatherForecast weatherForecast)
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