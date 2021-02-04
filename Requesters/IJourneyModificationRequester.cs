using System;

namespace IO_Project.JourneyInteraction
{
    public interface IJourneyModificationRequester
    {
        void ModifyJourney(Action modificationCallback, Action modificationFailCallback);
    }
}
