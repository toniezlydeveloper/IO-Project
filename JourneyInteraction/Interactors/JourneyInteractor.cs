using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.JourneyInteraction
{
    class JourneyInteractor : AInteractor, IJourneyCreator, IJourneyModifier
    {
        public JourneyInteractor(RequestOperator requestOperator)
            : base(requestOperator)
        {
        }

        public void CreateJourney(Action creationCallback, Action creationFailCallback)
        {
            TryInteracting(RequestType.CreateJourney, creationCallback, creationFailCallback);
        }

        public void ModifyJourney(Action modificationCallback, Action modificationFailCallback)
        {
            TryInteracting(RequestType.ModifyJourney, modificationCallback, modificationFailCallback);
        }
    }
}
