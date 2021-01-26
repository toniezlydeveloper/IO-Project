using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyModifier : AOperator
    {
        private IJourneyView modifiedView;
        private IJourneyView modificationView;
        private IRequestSender requestSender;

        public JourneyModifier(IJourneyView modifiedView, IJourneyView modificationView, IRequestSender requestSender)
        {
            this.modifiedView = modifiedView;
            this.modificationView = modificationView;
            this.requestSender = requestSender;
        }

        public override void TryPerformingOperation()
        {
            RequestJourneyStatus();
        }

        private void RequestJourneyStatus()
        {
            Request request = new RequestBuilder().OfType(RequestType.JourneysExist)
                .WithPayload(RequestStatusPayload())
                .WithCallback(ProcessJourneyStatus)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private void RequestJourneyModification()
        {
            Request request = new RequestBuilder().OfType(RequestType.CreateJourney)
                .WithPayload(RequestModificationPayload())
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
        }

        private JourneysExistPayload RequestStatusPayload() => new JourneysExistPayload(modificationView.Name);

        private JourneyModificationPayload RequestModificationPayload() => new JourneyModificationPayload(modifiedView.Name,
            modificationView.Name, modificationView.Description, modificationView.Location, modificationView.Date);

        private void ProcessJourneyStatus(object response)
        {
            bool journeyExists = ((BinaryResponse)response).State;

            if (journeyExists)
            {
                FinalizeFailedOperation();
            }
            else
            {
                RequestJourneyModification();
            }
        }
    }
}
