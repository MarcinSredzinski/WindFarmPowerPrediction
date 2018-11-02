using System;
using System.Collections.Generic;
using System.Text;
using PowerGenerationPredictionLibrary.PowerPlantModels.Parts;
namespace PowerGenerationPredictionLibrary.PowerPlantModels
{
    interface IWindTurbine
    {
         ITurbine Turbina { get; set; }
        IGenerator Generator { get; set; }


    }
}
