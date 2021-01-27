using System.Collections.Generic;

namespace IO_Project.JourneyInteraction
{
    interface IJourneySetPresenter
    {
        void PresentJourneySet(IEnumerable<Journey> journeys);
    }
}
