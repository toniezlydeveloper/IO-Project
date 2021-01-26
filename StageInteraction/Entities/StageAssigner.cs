using System;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction.Entities
{
    class StageAssigner : AOperator
    {
        private IStageView stageView;
        private IJourneyView journeyView;

        public StageAssigner(IStageView stageView, IJourneyView journeyView)
        {
            this.stageView = stageView;
            this.journeyView = journeyView;
        }

        public override void TryPerformingOperation()
        {
            if (!IsViewValid())
            {
                return;
            }
        }

        private bool IsViewValid()
        {
            return new StageSetupValidator(stageView).IsViewValid();
        }
    }
}
