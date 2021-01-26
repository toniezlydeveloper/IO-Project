using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction.Entities
{
    class StageAssigner : AOperator
    {
        private IStageView stageView;
        private IJourneyView journeyView;

        protected override RequestType HandledRequestType => RequestType.AssignStage;
        protected override object Payload => new StageAssignmentPayload(journeyView.Name,
            stageView.Name, stageView.Description, stageView.IconPath);

        public StageAssigner(IStageView stageView, IJourneyView journeyView, IRequestSender requestSender)
            : base (requestSender)
        {
            this.stageView = stageView;
            this.journeyView = journeyView;
        }
    }
}
