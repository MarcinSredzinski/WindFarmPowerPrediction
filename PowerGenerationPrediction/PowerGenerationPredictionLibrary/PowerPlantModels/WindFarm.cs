using PowerGenerationPredictionLibrary.PowerPlantModels.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGenerationPredictionLibrary.PowerPlantModels
{
    class WindFarm : IPowerPlantModel, IWindTurbine
    {
        public ITurbine Turbina { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGenerator Generator { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        ILocalization IPowerPlantModel.LocalizationOfPowerPlant => throw new NotImplementedException();

        int IPowerPlantModel.NominalPower => throw new NotImplementedException();

    }
}
