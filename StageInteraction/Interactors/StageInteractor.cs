using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction
{
    class StageInteractor : AInteractor, IStageAssigner, IStageModifier
    {
        public StageInteractor(RequestOperator requestOperator)
            : base(requestOperator)
        {
        }

        public void AssignStage(Action assignCallback, Action assignFailCallback)
        {
            TryInteracting(RequestType.AssignStage, assignCallback, assignFailCallback);
        }

        public void ModifyStage(Action modificationCallback, Action modificationFailCallback)
        {
            TryInteracting(RequestType.ModifyStage, modificationCallback, modificationFailCallback);
        }
    }
}
