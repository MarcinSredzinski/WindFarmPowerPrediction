using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary.PowerPlantModels
{
    class WindFarmMathematicalModel : IPowerPlantModel, IWindTurbine
    {
        ILocalization IPowerPlantModel.LocalizationOfPowerPlant => throw new NotImplementedException();

        int IPowerPlantModel.NominalPower => throw new NotImplementedException();

        IGenerator IPowerPlantModel.PowerPlantGenerator => throw new NotImplementedException();
    }
}
