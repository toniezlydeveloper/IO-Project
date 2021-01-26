using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction
{
    class StageInteractor : AInteractor, IStageAssigner, IStageModifier
    {
        private AOperator stageModifier;
        private AOperator stageAssigner;

        public StageInteractor(AOperator stageModifier, AOperator stageAssigner)
        {
            this.stageAssigner = stageAssigner;
            this.stageModifier = stageModifier;
        }

        public void AssignStage(Action assignCallback, Action assignFailCallback)
        {
            TryPerformingOperation(stageAssigner, assignCallback, assignFailCallback);
        }

        public void ModifyStage(Action modificationCallback, Action modificationFailCallback)
        {
            TryPerformingOperation(stageModifier, modificationCallback, modificationFailCallback);
        }
    }
}
