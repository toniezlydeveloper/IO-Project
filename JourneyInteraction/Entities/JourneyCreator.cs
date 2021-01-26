using System;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyCreator : IJourneyOperator
    {
        private Action creationCallback;
        private Action creationFailCallback;
        private IJourneyView creationView;
        private IRequestSender requestSender;

        public bool IsBusy { get; private set; }

        public JourneyCreator(IRequestSender requestSender, IJourneyView journeyView)
        {
            this.requestSender = requestSender;
            this.creationView = journeyView;
        }

        public void AssignOperationCallbacks(Action operationCallback, Action operationFailCalblack)
        {
            creationCallback = operationCallback;
            creationFailCallback = operationFailCalblack;
        }

        public void TryPerformingOperation()
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
                .WithFailCallback(FinalizeFailedCreationAttempt).Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private void RequestJourneyCreation()
        {
            Request request = new RequestBuilder().OfType(RequestType.CreateJourney)
                .WithPayload(RequestCreationPayload())
                .WithCallback(FinalizeCreationAttempt)
                .WithFailCallback(FinalizeFailedCreationAttempt).Build();
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
                FinalizeFailedCreationAttempt();
            }
            else
            {
                RequestJourneyCreation();
            }
        }

        private void FinalizeCreationAttempt(object response)
        {
            creationCallback?.Invoke();
            IsBusy = false;
        }

        private void FinalizeFailedCreationAttempt()
        {
            creationFailCallback?.Invoke();
            IsBusy = false;
        }
    }
}
