using System;

namespace IO_Project.JourneyInteraction
{
    interface IJourneyModifier
    {
        void ModifyJourney(Action modificationCallback, Action modificationFailCallback);
    }
}
