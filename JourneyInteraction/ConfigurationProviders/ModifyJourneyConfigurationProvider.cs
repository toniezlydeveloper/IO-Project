using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.JourneyInteraction.Entities
{
    class ModifyJourneyConfigurationProvider : IRequestConfigurationProvider
    {
        private IJourneyView modifiedView;
        private IJourneyView modificationView;

        public RequestType HandledRequestType => RequestType.ModifyJourney;
        public object Payload => new JourneyModificationPayload(modifiedView.Name,
            modificationView.Name, modificationView.Description, modificationView.Date);

        public ModifyJourneyConfigurationProvider(IJourneyView modifiedView, IJourneyView modificationView)
        {
            this.modifiedView = modifiedView;
            this.modificationView = modificationView;
        }
    }
}
