using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.ParticipantInteraction.Entities
{
    class ParticipantAssigner : AOperator
    {
        private IJourneyView journeyView;
        private IParticipantView participantView;

        protected override RequestType HandledRequestType => RequestType.AssignParticipant;
        protected override object Payload =>
            new ParticipantAssignmentPayload(journeyView.Name, participantView.FullName);

        public ParticipantAssigner(IJourneyView journeyView, IParticipantView participantView, IRequestSender requestSender)
            : base(requestSender)
        {
            this.journeyView = journeyView;
            this.participantView = participantView;
        }
    }
}
