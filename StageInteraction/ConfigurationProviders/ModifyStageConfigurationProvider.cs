using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;

namespace IO_Project.StageInteraction.Entities
{
    class ModifyStageConfigurationProvider : IRequestConfigurationProvider
    {
        private IStageView modifiedView;
        private IStageView modificationView;
        private IJourneyView journeyView;

        public RequestType HandledRequestType => RequestType.ModifyStage;
        public object Payload => new StageModificationPayload(journeyView.Name,
            modifiedView.Name, modificationView.Name, modificationView.Description, modificationView.IconPath);

        public ModifyStageConfigurationProvider(IStageView modificationView, IStageView modifiedView, IJourneyView journeyView)
        {
            this.modificationView = modificationView;
            this.modifiedView = modifiedView;
            this.journeyView = journeyView;
        }
    }
}
