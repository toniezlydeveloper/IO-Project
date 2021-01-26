using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.JourneyInteraction
{
    interface IJourneySetPresenter
    {
        void PresentJourneySet(IEnumerable<Journey> journeys);
    }
}
