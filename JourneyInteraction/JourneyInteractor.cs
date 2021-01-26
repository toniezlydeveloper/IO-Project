using System;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.JourneyInteraction
{
    class JourneyInteractor : IJourneyCreator, IJourneyModifier
    {
        private IJourneyView creationView;
        private IJourneyView modificationView;
        private IRequestSender requestSender;
        private JourneyCreator journeyCreator;

        public JourneyInteractor(IJourneyView creationView, IJourneyView modificationView, IRequestSender requestSender)
        {
            this.creationView = creationView;
            this.modificationView = modificationView;
            this.requestSender = requestSender;
            journeyCreator = new JourneyCreator(requestSender, creationView);
        }

        public void CreateJourney(Action creationCallback, Action creationFailCallback)
        {
            if (CanAttemptJourneyCreation())
            {
                journeyCreator.AssignCallbacks(creationCallback, creationFailCallback);
                journeyCreator.TryCreatingJourney();
            }
            else
            {
                creationFailCallback?.Invoke();
            }
        }

        public void ModifyJourney(Action modificationCallback, Action modificationFailCallback)
        {
        }

        private bool CanAttemptJourneyCreation()
        {
            return !journeyCreator.IsBusy && IsViewValid(creationView);
        }

        private bool IsViewValid(IJourneyView view)
        {
            return new JourneySetupValidator(view).IsViewValid();
        }
    }
}
