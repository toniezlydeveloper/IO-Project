using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO.Payloads
{
    class AssignParticipantPayload
    {
        public string FullName { get; }
        public string JourneyName { get; }

        public AssignParticipantPayload(string fullName, string journeyName)
        {
            FullName = fullName;
            JourneyName = journeyName;
        }
    }
}
