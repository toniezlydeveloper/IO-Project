using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.ParticipantInteraction.Entities
{
    class ParticipantCreator : AOperator
    {
        private IParticipantView participantView;

        protected override RequestType HandledRequestType => RequestType.CreateParticipant;
        protected override object Payload =>
            new ParticipantCreationPayload(participantView.FullName);

        public ParticipantCreator(IParticipantView participantView, IRequestSender requestSender)
            : base(requestSender)
        {
            this.participantView = participantView;
        }
    }
}
