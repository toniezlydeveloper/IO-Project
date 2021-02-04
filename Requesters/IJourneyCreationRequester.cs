using System;

namespace IO_Project.JourneyInteraction
{
    public interface IJourneyCreationRequester
    {
        void CreateJourney(Action creationCallback, Action creationFailCallback);
    }
}
