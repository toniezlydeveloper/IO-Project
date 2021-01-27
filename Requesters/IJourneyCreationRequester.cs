using System;

namespace IO_Project.JourneyInteraction
{
    interface IJourneyCreationRequester
    {
        void CreateJourney(Action creationCallback, Action creationFailCallback);
    }
}
