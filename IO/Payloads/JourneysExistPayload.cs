using System.Linq;

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
