using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyCreator
    {
        private Action creationCallback;
        private Action creationFailCallback;
        private IJourneyView journeyView;
        private IRequestSender requestSender;

        public bool IsBusy { get; private set; }

        public JourneyCreator(IRequestSender requestSender, IJourneyView journeyView)
        {
            this.requestSender = requestSender;
            this.journeyView = journeyView;
        }

        public void AssignCallbacks(Action creationCallback, Action creationFailCallback)
        {
            this.creationCallback = creationCallback;
            this.creationFailCallback = creationFailCallback;
        }

        public void TryCreatingJourney()
        {
            RequestJourneyStatus();
        }

        private void RequestJourneyStatus()
        {
            Request request = new RequestBuilder().OfType(RequestType.JourneysExist)
                .WithPayload(RequestStatusPayload())
                .WithCallback(ProcessJourneyStatus)
                .WithFailCallback(FinalizeFailedCreationAttempt).Build();
            requestSender.Send(request);
        }
        private void RequestJourneyCreation()
        {
            Request request = new RequestBuilder().OfType(RequestType.CreateJourney)
                .WithPayload(RequestCreationPayload())
                .WithCallback(FinalizeCreationAttempt)
                .WithFailCallback(FinalizeFailedCreationAttempt).Build();
            requestSender.Send(request);
        }

        private JourneysExistPayload RequestStatusPayload() => new JourneysExistPayload(journeyView.Name);

        private JourneyCreationPayload RequestCreationPayload() => new JourneyCreationPayload(journeyView.Name, journeyView.Description, journeyView.Location, journeyView.Date);

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
