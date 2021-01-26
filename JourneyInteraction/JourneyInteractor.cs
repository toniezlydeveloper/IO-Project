using System;

namespace IO_Project.JourneyInteraction
{
    class JourneyInteractor : IJourneyCreator
    {
        private IJourneyView creationView;

        public void CreateJourney(Action creationCallback, Action creationFailCallback)
        {
        }
    }
}
