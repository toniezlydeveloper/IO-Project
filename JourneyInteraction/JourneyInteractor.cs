using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.JourneyInteraction
{
    class JourneyInteractor : AInteractor, IJourneyCreator, IJourneyModifier
    {
        private AOperator journeyCreator;
        private AOperator journeyModifier;

        public JourneyInteractor(AOperator journeyCreator, AOperator journeyModifier)
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
    }
}
