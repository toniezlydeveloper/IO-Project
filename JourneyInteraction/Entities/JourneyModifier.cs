using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyModifier : AOperator
    {
        private IJourneyView modifiedView;
        private IJourneyView modificationView;

        protected override RequestType HandledRequestType => RequestType.ModifyJourney;
        protected override object Payload => new JourneyModificationPayload(modifiedView.Name,
            modificationView.Name, modificationView.Description, modificationView.Location, modificationView.Date);

        public JourneyModifier(IJourneyView modifiedView, IJourneyView modificationView, IRequestSender requestSender)
            : base(requestSender)
        {
            this.modifiedView = modifiedView;
            this.modificationView = modificationView;
        }
    }
}
