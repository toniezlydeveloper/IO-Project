using System.Collections.Generic;
using System.Linq;
using IO_Project.JourneyInteraction;
using IO_Project.ParticipantInteraction;

namespace IO_Project.Core
{
    class Journal
    {
        private List<Journey> journeys = new List<Journey>();
        private List<Participant> participants = new List<Participant>();

        public void AddJourney(Journey journey)
        {
            journeys.Add(journey);
        }

        public Journey JourneyByName(string name)
        {
            return journeys.First(journey => journey.Name == name);
        }

        public void AddParticipant(Participant participant)
        {
            participants.Add(participant);
        }

        public Participant ParticipantByFullName(string fullName)
        {
            return participants.First(participant => participant.FullName == fullName);
        }
    }
}
