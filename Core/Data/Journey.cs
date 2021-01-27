using System.Collections.Generic;
using IO_Project.ParticipantInteraction;
using IO_Project.StageInteraction;

namespace IO_Project.JourneyInteraction
{
    class Journey
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public List<Stage> Stages { get; set; }
        public List<Participant> ParticipantNames { get; set; }
    }
}
