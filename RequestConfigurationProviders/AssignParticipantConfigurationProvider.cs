using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;

namespace IO_Project.ParticipantInteraction.Entities
{
    class AssignParticipantConfigurationProvider : IRequestConfigurationProvider
    {
        private IJourneyView journeyView;
        private IParticipantView participantView;

        public RequestType HandledRequestType => RequestType.AssignParticipant;
        public object Payload =>
            new ParticipantAssignmentPayload(journeyView.Name, participantView.FullName);

        public AssignParticipantConfigurationProvider(IJourneyView journeyView, IParticipantView participantView)
        {
            this.journeyView = journeyView;
            this.participantView = participantView;
        }
    }
}
