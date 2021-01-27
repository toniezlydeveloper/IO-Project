using System;

namespace IO_Project.JourneyInteraction
{
    interface IJourneyModificationRequester
    {
        void ModifyJourney(Action modificationCallback, Action modificationFailCallback);
    }
}
