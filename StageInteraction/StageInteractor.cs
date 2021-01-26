using System;
using IO_Project.JourneyInteraction;

namespace IO_Project.StageInteraction
{
    class StageInteractor : IStageAssigner, IStageModifier
    {
        private IStageView stageView;
        private IJourneyView journeyView;

        public void AssignStage(Action assignCallback, Action assignFailCallback)
        {
        }

        public void ModifyStage(Action modificationCallback, Action modificationFailCallback)
        {
        }
    }
}
