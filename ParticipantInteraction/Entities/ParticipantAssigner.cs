using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.ParticipantInteraction.Entities
{
    class ParticipantAssigner : AOperator
    {
        private IJourneyView journeyView;
        private IRequestSender requestSender;
        private IParticipantView participantView;

        public ParticipantAssigner(IJourneyView journeyView, IParticipantView participantView, IRequestSender requestSender)
        {
            this.journeyView = journeyView;
            this.participantView = participantView;
            this.requestSender = requestSender;
        }

        public override void TryPerformingOperation()
        {
            RequestParticipantAssignment();
        }

        private void RequestParticipantAssignment()
        {
            Request request = new RequestBuilder().OfType(RequestType.AssignParticipant)
                .WithPayload(ParticipantAssignmentRequestPayload())
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private ParticipantAssignmentPayload ParticipantAssignmentRequestPayload() => 
            new ParticipantAssignmentPayload(journeyView.Name, participantView.FullName);
    }
}
