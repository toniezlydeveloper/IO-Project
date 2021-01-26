using System;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.JourneyInteraction
{
    class JourneyInteractor : IJourneyCreator, IJourneyModifier
    {
        private IJourneyOperator journeyCreator;
        private IJourneyOperator journeyModifier;

        public JourneyInteractor(IJourneyOperator journeyCreator, IJourneyOperator journeyModifier)
        {
            this.journeyCreator = journeyCreator;
            this.journeyModifier = journeyModifier;
        }

        public void CreateJourney(Action creationCallback, Action creationFailCallback)
        {
            TryPerformingOperation(journeyCreator, creationCallback, creationFailCallback);
        }

        public void ModifyJourney(Action modificationCallback, Action modificationFailCallback)
        {
            TryPerformingOperation(journeyModifier, modificationCallback, modificationFailCallback);
        }

        private void TryPerformingOperation(IJourneyOperator journeyOperator, Action operationCallback, Action operationFailCallback)
        {
            if (journeyOperator.IsBusy)
            {
                operationFailCallback?.Invoke();
            }
            else
            {
                journeyOperator.AssignOperationCallbacks(operationCallback, operationFailCallback);
                journeyOperator.TryPerformingOperation();
            }
        }
    }
}
