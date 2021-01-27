using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.JourneyInteraction
{
    class JourneyInteractor : ARequester, IJourneyCreationRequester, IJourneyModificationRequester
    {
        public JourneyInteractor(RequestInteractor requestInteractor)
            : base(requestInteractor)
        {
        }

        public void CreateJourney(Action creationCallback, Action creationFailCallback)
        {
            TryRequesting(RequestType.CreateJourney, creationCallback, creationFailCallback);
        }

        public void ModifyJourney(Action modificationCallback, Action modificationFailCallback)
        {
            TryRequesting(RequestType.ModifyJourney, modificationCallback, modificationFailCallback);
        }
    }
}
