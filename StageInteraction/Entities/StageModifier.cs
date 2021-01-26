using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction.Entities
{
    class StageModifier : AOperator
    {
        private IStageView modifiedView;
        private IStageView modificationView;
        private IJourneyView journeyView;

        protected override RequestType HandledRequestType => RequestType.ModifyStage;
        protected override object Payload => new StageModificationPayload(journeyView.Name,
            modifiedView.Name, modificationView.Name, modificationView.Description, modificationView.IconPath);

        public StageModifier(IStageView modificationView, IStageView modifiedView, IJourneyView journeyView, IRequestSender requestSender)
            : base(requestSender)
        {
            this.modificationView = modificationView;
            this.modifiedView = modifiedView;
            this.journeyView = journeyView;
        }
    }
}
