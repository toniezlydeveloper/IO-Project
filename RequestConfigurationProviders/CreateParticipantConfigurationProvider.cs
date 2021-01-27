using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.ParticipantInteraction.Entities
{
    class CreateParticipantConfigurationProvider : IRequestConfigurationProvider
    {
        private IParticipantView participantView;

        public RequestType HandledRequestType => RequestType.CreateParticipant;
        public object Payload =>
            new ParticipantCreationPayload(participantView.FullName);

        public CreateParticipantConfigurationProvider(IParticipantView participantView)
        {
            this.participantView = participantView;
        }
    }
}
