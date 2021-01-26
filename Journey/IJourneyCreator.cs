using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.Journey
{
    interface IJourneyCreator
    {
        void CreateJourney(Action creationCallback, Action creationFailCallback);
    }
}
