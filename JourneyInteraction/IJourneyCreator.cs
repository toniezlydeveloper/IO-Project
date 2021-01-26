using System;

namespace IO_Project.JourneyInteraction
{
    interface IJourneyCreator
    {
        void CreateJourney(Action creationCallback, Action creationFailCallback);
    }
}
