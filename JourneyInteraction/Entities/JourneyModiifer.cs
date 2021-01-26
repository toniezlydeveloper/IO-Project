using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyModiifer : IJourneyOperator
    {
        private IJourneyView modifiedView;
        private IJourneyView modificationView;
        private IRequestSender requestSender;
        private Action modificationCallback;
        private Action modificationFailCallback;

        public bool IsBusy { get; private set; }

        public JourneyModiifer(IJourneyView modifiedView, IJourneyView modificationView, IRequestSender requestSender)
        {
            this.modifiedView = modifiedView;
            this.modificationView = modificationView;
            this.requestSender = requestSender;
        }

        public void AssignOperationCallbacks(Action operationCallback, Action operationFailCallback)
        {
            modificationCallback = operationCallback;
            modificationFailCallback = operationFailCallback;
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
            return new JourneySetupValidator(modificationView).IsViewValid();
        }
        private void RequestJourneyStatus()
        {
            Request request = new RequestBuilder().OfType(RequestType.JourneysExist)
                .WithPayload(RequestStatusPayload())
                .WithCallback(ProcessJourneyStatus)
                .WithFailCallback(FinalizeFailedModificationAttempt).Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private void RequestJourneyModification()
        {
            Request request = new RequestBuilder().OfType(RequestType.CreateJourney)
                .WithPayload(RequestModificationPayload())
                .WithCallback(FinalizeModificationAttempt)
                .WithFailCallback(FinalizeFailedModificationAttempt).Build();
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
                FinalizeFailedModificationAttempt();
            }
            else
            {
                RequestJourneyModification();
            }
        }

        private void FinalizeModificationAttempt(object response)
        {
            modificationCallback?.Invoke();
            IsBusy = false;
        }

        private void FinalizeFailedModificationAttempt()
        {
            modificationFailCallback?.Invoke();
            IsBusy = false;
        }
    }
}
