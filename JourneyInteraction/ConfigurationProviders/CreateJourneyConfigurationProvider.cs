using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.JourneyInteraction.Entities
{
    class CreateJourneyConfigurationProvider : IRequestConfigurationProvider
    {
        private IJourneyView creationView;

        public RequestType HandledRequestType => RequestType.CreateJourney;
        public object Payload => new JourneyCreationPayload(creationView.Name,
            creationView.Description, creationView.Location, creationView.Date);

        public CreateJourneyConfigurationProvider(IJourneyView journeyView)
        {
            this.creationView = journeyView;
        }
    }
}
