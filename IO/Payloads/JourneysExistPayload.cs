using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO_Project.IO.Payloads
{
    class JourneysExistPayload
    {
        string[] JourneyNames { get; }

        public JourneysExistPayload(params string[] journeyNames)
        {
            JourneyNames = journeyNames.ToArray();
        }
    }
}
