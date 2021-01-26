using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.ParticipantInteraction.Entities
{
    class ParticipantCreator : AOperator
    {
        private IRequestSender requestSender;
        private IParticipantView participantView;

        public ParticipantCreator(IParticipantView participantView, IRequestSender requestSender)
        {
            this.participantView = participantView;
            this.requestSender = requestSender;
        }

        public override void TryPerformingOperation()
        {
            RequestParticipantCreation();
        }

        private void RequestParticipantCreation()
        {
            Request request = new RequestBuilder().OfType(RequestType.CreateParticipant)
                .WithPayload(ParticipantAssignmentRequestPayload())
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private ParticipantCreationPayload ParticipantAssignmentRequestPayload() => 
            new ParticipantCreationPayload(participantView.FullName);
    }
}
