using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO.Payloads
{
    class ParticipantCreationPayload
    {
        public string FullName { get; }

        public ParticipantCreationPayload(string fullName)
        {
            FullName = fullName;
        }
    }
}
