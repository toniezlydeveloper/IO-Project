using System;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyCreator : AOperator
    {
        private IJourneyView creationView;
        private IRequestSender requestSender;

        public JourneyCreator(IRequestSender requestSender, IJourneyView journeyView)
        {
            this.requestSender = requestSender;
            this.creationView = journeyView;
        }

        public override void TryPerformingOperation()
        {
            if (!IsViewValid())
            {
                return;
            }

            RequestJourneyStatus();
        }

        private bool IsViewValid()
        {
            return new JourneySetupValidator(creationView).IsViewValid();
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

        private void RequestJourneyCreation()
        {
            Request request = new RequestBuilder().OfType(RequestType.CreateJourney)
                .WithPayload(RequestCreationPayload())
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
        }

        private JourneysExistPayload RequestStatusPayload() => new JourneysExistPayload(creationView.Name);

        private JourneyCreationPayload RequestCreationPayload() => new JourneyCreationPayload(creationView.Name,
            creationView.Description, creationView.Location, creationView.Date);

        private void ProcessJourneyStatus(object response)
        {
            bool journeyExists = ((BinaryResponse)response).State;

            if (journeyExists)
            {
                FinalizeFailedOperation();
            }
            else
            {
                RequestJourneyCreation();
            }
        }
    }
}
