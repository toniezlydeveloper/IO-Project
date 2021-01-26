using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO.Payloads
{
    class ParticipantAssignmentStatusPayload
    {
        public string JourneyName { get; }
        public string ParticipantFullName { get; }

        public ParticipantAssignmentStatusPayload(string journeyName, string participantFullName)
        {
            JourneyName = journeyName;
            ParticipantFullName = participantFullName;
        }
    }
}
