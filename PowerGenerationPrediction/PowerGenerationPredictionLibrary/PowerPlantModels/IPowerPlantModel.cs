using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary.PowerPlantModels
{
    public interface IPowerPlantModel
    {
         ILocalization LocalizationOfPowerPlant { get; } 
         int NominalPower { get; }
         IGenerator PowerPlantGenerator { get; }
    }
}
