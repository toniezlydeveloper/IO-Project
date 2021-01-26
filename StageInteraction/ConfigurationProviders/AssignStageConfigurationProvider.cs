using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;

namespace IO_Project.StageInteraction.Entities
{
    class AssignStageConfigurationProvider : IRequestConfigurationProvider
    {
        private IStageView stageView;
        private IJourneyView journeyView;

        public RequestType HandledRequestType => RequestType.AssignStage;
        public object Payload => new StageAssignmentPayload(journeyView.Name,
            stageView.Name, stageView.Description, stageView.IconPath);

        public AssignStageConfigurationProvider(IStageView stageView, IJourneyView journeyView)
        {
            this.stageView = stageView;
            this.journeyView = journeyView;
        }
    }
}
